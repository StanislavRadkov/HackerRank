using System.Linq;
using System.Text;

namespace Implementation
{
    // https://www.hackerrank.com/challenges/designer-pdf-viewer
    public static class DesignerPDFViewer
    {
        public static int Solve(int[] heights, string word)
        {
            var maxHeight = Encoding.ASCII.GetBytes(word).Select(v => heights[v - 97]).Max();

            return maxHeight * word.Length;
        }
    }
}
