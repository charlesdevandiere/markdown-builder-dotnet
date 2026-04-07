using Markdown;
using Xunit;

namespace MarkdownBuiler.UnitTests;

public class MarkdownTableTest
{
    [Fact]
    public void TestHeader()
    {
        {
            var table = new MarkdownTable(new MarkdownTableHeader(3));
            Assert.Equal(3, table.Header.Cells.Length);
        }
        {
            var header = new MarkdownTableHeader(
                new MarkdownTableHeaderCell(""),
                new MarkdownTableHeaderCell(""),
                new MarkdownTableHeaderCell("")
            );
            var table = new MarkdownTable(header);
            Assert.Equal(3, table.Header.Cells.Length);
        }
    }

    [Fact]
    public void TestNullHeader()
    {
#pragma warning disable CS8604 // Intentionally passing null to test Guard validation
        MarkdownTableHeader? header = null;
        Assert.Throws<ArgumentNullException>(() => new MarkdownTable(header));
#pragma warning restore CS8604
    }

    [Fact]
    public void TestColumnCount()
    {
        var table = new MarkdownTable(new MarkdownTableHeader(3));
        Assert.Equal(3, table.ColumnCount);
    }

    [Fact]
    public void TestRows()
    {
        {
            var table = new MarkdownTable(
                new MarkdownTableHeader(3),
                2
            );
            Assert.Equal(0, table.RowsCount);
            Assert.Equal(2, table.RowsCapacity);
        }
        {
            var table = new MarkdownTable(
                new MarkdownTableHeader(3),
                new MarkdownTableRow[]
                {
                    new MarkdownTableRow(3),
                    new MarkdownTableRow(3)
                }
            );
            Assert.Equal(2, table.RowsCount);
            Assert.Equal(2, table.RowsCapacity);
        }
    }

    [Fact]
    public void TestRowsCapacity()
    {
        var table = new MarkdownTable(new MarkdownTableHeader(3));
        table.RowsCapacity = 3;
        Assert.Equal(3, table.RowsCapacity);
    }

    [Fact]
    public void TestNegativeRowsCapacity()
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => new MarkdownTable(
                new MarkdownTableHeader(3),
                -1
            )
        );
        Assert.Throws<ArgumentOutOfRangeException>(
            () => new MarkdownTable(new MarkdownTableHeader(3)).RowsCapacity = -1
        );
    }

    [Fact]
    public void TestInitializeWithInvalidRow()
    {
        Assert.Throws<ArgumentException>(
            () => new MarkdownTable(
                new MarkdownTableHeader(3),
                new MarkdownTableRow[] { new MarkdownTableRow(2) }
            )
        );
    }

    [Fact]
    public void TestAddRow()
    {
        var table = new MarkdownTable(new MarkdownTableHeader(3));
        table.AddRow(new MarkdownTableRow("A", "B", "C"));

        Assert.Equal(1, table.RowsCount);
    }

    [Fact]
    public void TestAddInvalidRow()
    {
        var table = new MarkdownTable(new MarkdownTableHeader(3));
        Assert.Throws<ArgumentException>(() => table.AddRow(new MarkdownTableRow("A", "B")));
        Assert.Equal(0, table.RowsCount);
    }

    [Fact]
    public void TestAddRowRange()
    {
        var table = new MarkdownTable(new MarkdownTableHeader(3));
        MarkdownTableRow[] rows =
        {
            new MarkdownTableRow("A", "B", "C"),
            new MarkdownTableRow("A", "B", "C")
        };
        table.AddRowRange(rows);

        Assert.Equal(2, table.RowsCount);
    }

    [Fact]
    public void TestAddInvalidRowRange()
    {
        var table = new MarkdownTable(new MarkdownTableHeader(3));
        MarkdownTableRow[] rows =
        {
            new MarkdownTableRow("A", "B"),
            new MarkdownTableRow("A", "B")
        };
        Assert.Throws<ArgumentException>(() => table.AddRowRange(rows));
        Assert.Equal(0, table.RowsCount);
    }

    [Fact]
    public void TestGetRowAt()
    {
        var table = new MarkdownTable(new MarkdownTableHeader(3));
        var row = new MarkdownTableRow("A", "B", "C");
        table.AddRow(row);

        Assert.Equal(row, table.GetRowAt(0));
    }

    [Fact]
    public void TestRemoveRowAt()
    {
        var table = new MarkdownTable(new MarkdownTableHeader(3));
        table.AddRow(new MarkdownTableRow("A", "B", "C"));
        table.RemoveRowAt(0);

        Assert.Equal(0, table.RowsCount);
    }

    [Fact]
    public void TestToString()
    {
        var table = new MarkdownTable(
            new MarkdownTableHeader(
                new MarkdownTableHeaderCell[]
                {
                    new MarkdownTableHeaderCell("Header"),
                    new MarkdownTableHeaderCell("Header")
                }
            ),
            new MarkdownTableRow[]
            {
                new MarkdownTableRow("cell", "cell"),
                new MarkdownTableRow("cell", "cell")
            }
        );
        Assert.Equal(
            "| Header | Header |" + Environment.NewLine +
            "| --- | --- |" + Environment.NewLine +
            "| cell | cell |" + Environment.NewLine +
            "| cell | cell |" + Environment.NewLine,
            table.ToString()
        );
    }

    [Fact]
    public void TestAddNullRow()
    {
#pragma warning disable CS8600, CS8625
        var table = new MarkdownTable(new MarkdownTableHeader(3));
        Assert.Throws<ArgumentNullException>(() => table.AddRow(null));
#pragma warning restore CS8600, CS8625
    }

    [Fact]
    public void TestToPrettyString()
    {
        var table = new MarkdownTable(
            new MarkdownTableHeader(
                new MarkdownTableHeaderCell("Name"),
                new MarkdownTableHeaderCell("Age")
            ),
            new MarkdownTableRow[]
            {
                new MarkdownTableRow("Alexandria", "5"),
                new MarkdownTableRow("John", "30")
            }
        );

        string expected =
            "| Name       | Age |" + Environment.NewLine +
            "| ---------- | --- |" + Environment.NewLine +
            "| Alexandria | 5   |" + Environment.NewLine +
            "| John       | 30  |" + Environment.NewLine;

        Assert.Equal(expected, table.ToPrettyString());
    }

    [Fact]
    public void TestToPrettyStringWithAlignment()
    {
        var table = new MarkdownTable(
            new MarkdownTableHeader(
                new MarkdownTableHeaderCell("Left", MarkdownTableTextAlignment.Left),
                new MarkdownTableHeaderCell("Center", MarkdownTableTextAlignment.Center),
                new MarkdownTableHeaderCell("Right", MarkdownTableTextAlignment.Right)
            ),
            new MarkdownTableRow[]
            {
                new MarkdownTableRow("A", "B", "C")
            }
        );

        string expected =
            "| Left | Center | Right |" + Environment.NewLine +
            "| :--- | :----: | ----: |" + Environment.NewLine +
            "| A    | B      | C     |" + Environment.NewLine;

        Assert.Equal(expected, table.ToPrettyString());
    }

    [Fact]
    public void TestToPrettyStringMinimumWidth()
    {
        var table = new MarkdownTable(
            new MarkdownTableHeader(
                new MarkdownTableHeaderCell("A"),
                new MarkdownTableHeaderCell("B")
            ),
            new MarkdownTableRow[]
            {
                new MarkdownTableRow("X", "Y")
            }
        );

        string expected =
            "| A   | B   |" + Environment.NewLine +
            "| --- | --- |" + Environment.NewLine +
            "| X   | Y   |" + Environment.NewLine;

        Assert.Equal(expected, table.ToPrettyString());
    }
}
