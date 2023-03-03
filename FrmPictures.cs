using Microsoft.VisualBasic.FileIO;
using System.Globalization;

namespace MNISTPics;
public partial class FrmPictures : Form
{
    #region Global Variables                    
    int bookMark = 0, numberOfRows;         // Used to browse the results
    readonly int nRows = 28, nCols = 28;    // Every digit is represented in a 28x28 pixels image
    string[][]? data;                       // Full file will contain [60000][785]
    // Hard coded file location
    string path = @"D:\Tutorials\MNIST\HandWrtDigits\mnist_train.csv";
    #endregion

    public FrmPictures() => InitializeComponent();
    private void FrmPictures_Activated(object sender, EventArgs e)
    {
        txtFileLocation.Text = path; txtFileLocation.Focus();
    }
    private void BtnLoad_Click(object sender, EventArgs e)
    {
        try
        {
            Cursor.Current = Cursors.WaitCursor;

            //  Begin ---- Here starts the code to load the database ----
            int numberOfColumns = File.ReadLines(path).First().Split(',').Length;    // This number will be 784
            numberOfRows = int.Parse(txtRowCount.Text, NumberStyles.AllowThousands); // Choose part of the data  

            TextFieldParser parser = new TextFieldParser(path);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");

            data = new string[numberOfRows][];
            for (int i = 0; i < numberOfRows; i++) { data[i] = parser.ReadFields()!; }
            //  End   ---- Here ends the code to load the database  ----

            //  Sort data array by digit 0 to 9
            data = data.OrderBy(subarr => subarr[0]).ToArray();

            //  Show first digit
            bookMark = 0;
            DrawDigit(bookMark);
        }
        catch (Exception ex)
        { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        finally { Cursor.Current = Cursors.Default; }
    }
    private void ChkDarkMode_CheckedChanged(object sender, EventArgs e)
    {
        if (data is not null) DrawDigit(bookMark);
    }
    private void BtnGetFirst_Click(object sender, EventArgs e)
    {
        bookMark = 0;
        DrawDigit(bookMark);
    }
    private void BtnGetPrevious_Click(object sender, EventArgs e)
    {
        if (bookMark > 0) DrawDigit(--bookMark);
    }
    private void BtnGetNext_Click(object sender, EventArgs e)
    {
        if (bookMark < numberOfRows - 1) DrawDigit(++bookMark);
    }
    private void BtnGetLast_Click(object sender, EventArgs e)
    {
        bookMark = numberOfRows - 1;
        DrawDigit(bookMark);
    }
    private void DrawDigit(int bkMark)
    {
        try
        {
            Bitmap image = new Bitmap(nCols, nRows); // Remember every digit was built as 28x28 pixels
            int pixelValue = 0;

            (string label, string[] pixels) Digit = (data![bkMark][0], data[bkMark][1..]);

            labNumber.Text = Digit.label;

            for (int row = 0; row < nRows; row++)
                for (int column = 0; column < nCols; column++)
                {
                    pixelValue = int.Parse(Digit.pixels[row * nRows + column].ToString());
                    pixelValue = (chkDarkMode.Checked ? pixelValue : 255 - pixelValue);     // Toggles dark mode
                    image.SetPixel(column, row, Color.FromArgb(pixelValue, pixelValue, pixelValue));
                }

            picB.Image = image;
            picB.SizeMode = PictureBoxSizeMode.Zoom;

            txtCurrentRow.Text = bkMark.ToString("N0");
        }
        catch (Exception ex)
        { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }
    private void TxtFileLocation_Leave(object sender, EventArgs e)
    {
        CheckFileLocation();
    }
    private void CheckFileLocation()
    {
        try
        {
            path = txtFileLocation.Text;
            txtRowCount.Text = File.ReadLines(path).Count().ToString("N0");
        }
        catch (IOException ex)
        { MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
    }
}