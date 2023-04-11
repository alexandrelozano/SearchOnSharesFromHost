using Microsoft.VisualBasic;

namespace SearchOnSharesFromHost
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void Log(string text)
        {
            txtOut.Text += Environment.NewLine + text;
            txtOut.SelectionStart = txtOut.Text.Length;
            txtOut.ScrollToCaret();
            Refresh();
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            txtOut.Text = "";
            Log($"Start searching files '{txtFilename.Text}' in {txtBasePath.Text}");

            GetNetShares ns = new GetNetShares();
            GetNetShares.SHARE_INFO_1[] shares = ns.EnumNetShares(txtBasePath.Text);

            foreach (GetNetShares.SHARE_INFO_1 share in shares)
            {
                string dirBase = txtBasePath.Text + @"\" + share.shi1_netname;

                if (Strings.InStr(dirBase, "$") == 0 || chkHiddenShares.Checked == true)
                {
                    Log($"Searching in {dirBase}");

                    try
                    {
                        string[] myfiles = Directory.GetFiles(dirBase, "*" + txtFilename.Text + "*.*", SearchOption.AllDirectories);
                        if (myfiles is not null)
                        {
                            foreach (var file in myfiles)
                                Log("*****Find " + file);
                        }
                    }
                    catch (Exception ex)
                    {
                        Log("!!!" + ex.Message);
                    }
                }
            }

            Cursor = Cursors.Default;
        }
    }
}