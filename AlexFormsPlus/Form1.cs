using System;
using System.Windows.Forms;
using Octokit;

namespace AlexFormsPlus
{
    public partial class Form1 : Form
    {
        private const string RepoOwner = "Trident35ro";
        private const string RepoName = "AlexFormsPlus";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Create a GitHub client
                var github = new GitHubClient(new ProductHeaderValue("UpdateChecker"));

                // Get the latest release of your repository
                var latestRelease = github.Repository.Release.GetLatest(RepoOwner, RepoName).Result;

                // Compare version numbers
                Version latestVersion = new Version(latestRelease.TagName);
                Version currentVersion = new Version(System.Windows.Forms.Application.ProductVersion);

                if (latestVersion > currentVersion)
                {
                    // New version available, prompt the user to update
                    DialogResult result = MessageBox.Show("A new version is available. Do you want to visit the release page to download the update?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        // Open the release page in the default web browser
                        System.Diagnostics.Process.Start(latestRelease.HtmlUrl);
                    }
                }
                else
                {
                    // No updates available
                    MessageBox.Show("You're using the latest version.", "No Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"Error checking for updates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ce poate face acest instrument:\n- Efectuarea adunării, scăderii, îmulțirii și împărțirii numerelor date;\n- Puteți ajunge la infinit (cumva, nu eu am făcut asta dar e bine venit, cred);\n- Efectuarea calculelor cu zecimale.\nFeature-uri propuse:\n- Alte operații de calcul mai complicate (de exemplu: %, sin, cos, tg sau ctg).");
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ce poate face acest instrument:\n- Poate afișa punctele introduse prin meniul de jos;\n- Se poate da zoom prin intermediul rotiței de la mouse;\n- Poați să identifici coordonatele prin numerele de pe axe.\nFeature-uri propuse:\n- Afișarea coordonatelor punctelor și denumirea lor;\n- Zooming mai bun.");
            Form4 Form4 = new Form4();
            Form4.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("REal");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
        }
    }
}
