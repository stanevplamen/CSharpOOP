using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    public class HtmlTable : HtmlElement, ITable
    {
        private int rows;
        private int cols;
        private IElement[,] tableCells;

        public HtmlTable(int rows, int cols) : base ("table")
        {
            this.Name = "table";
            this.rows = rows;
            this.cols = cols;
            this.tableCells = new IElement[rows, cols];
        }

        public int Rows
        {
            get { return this.rows; }
        }

        public int Cols
        {
            get { return this.cols; }
        }

        public IElement this[int row, int col]
        {
            get
            {
                return this.tableCells[row, col];
            }

            set
            {
                this.tableCells[row, col] = value;
            }
        }

        public override void Render(StringBuilder output)
        {
            output.Append("<table>");
			for (int row = 0; row < this.Rows; row++)
			{
				output.Append("<tr>");
				for (int col = 0; col < this.Cols; col++)
				{
					output.Append("<td>");
					this.tableCells[row, col].Render(output);
					output.Append("</td>");
				}
				output.Append("</tr>");
			}
			output.Append("</table>");		
        }
    }
}
