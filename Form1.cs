namespace Kalkulatorprosty;

public partial class Form1 : Form
{
    Double fNum, sNum;
    string Operation;
    public Form1()
    {
        InitializeComponent();
        numOut.Text = "0";
    }
    private void Form1_Load(object sender, EventArgs e)
    {
       
    }
    private void NUM1_Click(object sender, EventArgs e)
    {
        if (numOut.Text == "0")
        {
            numOut.Text = "1";
        }
        else
        {
            numOut.Text += "1";
        }
    }

    private void NUM0_Click(object sender, EventArgs e)
    {
        if (numOut.Text == "0")
        {
            numOut.Text = "0";
        }
        else
        {
            numOut.Text += "0";
        }
    }

    private void NUM2_Click(object sender, EventArgs e)
    {
        if (numOut.Text == "0")
        {
            numOut.Text = "2";
        }
        else
        {
            numOut.Text += "2";
        }
    }

    private void NUM3_Click(object sender, EventArgs e)
    {
        if (numOut.Text == "0")
        {
            numOut.Text = "3";
        }
        else
        {
            numOut.Text += "3";
        }
    }

    private void NUM6_Click(object sender, EventArgs e)
    {
        if (numOut.Text == "0")
        {
            numOut.Text = "6";
        }
        else
        {
            numOut.Text += "6";
        }
    }

    private void NUM5_Click(object sender, EventArgs e)
    {
        if (numOut.Text == "0")
        {
            numOut.Text = "5";
        }
        else
        {
            numOut.Text += "5";
        }
    }

    private void NUM4_Click(object sender, EventArgs e)
    {
        if (numOut.Text == "0")
        {
            numOut.Text = "4";
        }
        else
        {
            numOut.Text += "4";
        }
    }

    private void NUM9_Click(object sender, EventArgs e)
    {
        if (numOut.Text == "0")
        {
            numOut.Text = "9";
        }
        else
        {
            numOut.Text += "9";
        }
    }

    private void NUM8_Click(object sender, EventArgs e)
    {
        if (numOut.Text == "0")
        {
            numOut.Text = "8";
        }
        else
        {
            numOut.Text += "8";
        }
    }


    private void NUM7_Click(object sender, EventArgs e)
    {
        if (numOut.Text == "0")
        {
            numOut.Text = "7";
        }
        else
        {
            numOut.Text += "7";
        }
    }

    private void PLUS_Click(object sender, EventArgs e)
    {
        fNum = double.Parse(numOut.Text);
        Operation = "+";
        numOut.Text = "";
    }

    private void MINUS_Click(object sender, EventArgs e)
    {
        fNum = double.Parse(numOut.Text);
        Operation = "-";
        numOut.Text = "";
    }

    private void MULTIPLY_Click(object sender, EventArgs e)
    {
        fNum = double.Parse(numOut.Text);
        Operation = "*";
        numOut.Text = "";
    }

    private void DIVIDE_Click(object sender, EventArgs e)
    {
        fNum = double.Parse(numOut.Text);
        Operation = "/";
        numOut.Text = "";
    }

    private void CHANGE_Click(object sender, EventArgs e)
    {
        double change = Convert.ToDouble(numOut.Text);
        numOut.Text = Convert.ToString(change * -1);
    }

    private void CLEARALL_Click(object sender, EventArgs e)
    {
        numOut.Text = "0";
    }

    private void CLEARROW_Click(object sender, EventArgs e)
    {
        numOut.Text = "0";
        string f1, s1;
        f1 = Convert.ToString(fNum);
        s1= Convert.ToString(sNum);
        f1 = "";
        s1 = "";
    }

    private void BCKSPC_Click(object sender, EventArgs e)
    {
        if (numOut.Text.Length>0)
        {
            numOut.Text = numOut.Text.Remove(numOut.Text.Length - 1, 1);
        }

        if (numOut.Text == "")
        {
            numOut.Text = "0";
        }
    }
    private void button4_Click(object sender, EventArgs e)
    {
        if (!numOut.Text.Contains(","))
        {
            numOut.Text += ",";
        }
    }
    
    private void EQUAL_Click(object sender, EventArgs e)
    {
        sNum = double.Parse(numOut.Text);
        switch (Operation)
        {
            case "+":
                numOut.Text = Convert.ToString(fNum + sNum);
                break;
            case "-":
                numOut.Text = Convert.ToString(fNum - sNum);
                break;
            case "*":
                numOut.Text = Convert.ToString(fNum * sNum);
                break;
            case "/":
                if (sNum != 0)
                    numOut.Text = Convert.ToString(fNum / sNum);
                else
                    numOut.Text = "Error"; 
                break;
            default:
                numOut.Text = "0";
                break;
        }
    }

  
}