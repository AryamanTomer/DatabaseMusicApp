using System.Linq.Expressions;
using System.Net;
using System.Windows.Forms;

namespace DatabaseMusicApplication
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();
        List<Track> tracks = new List<Track>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // Connect the List to the grid view control
            albums = albumsDAO.getAllAlbums();
            albumBindingSource.DataSource = albums;
            dataGridView1.DataSource = albumBindingSource;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // Connect the List to the grid view control
            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);
            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            // Ensure that there is at least one row in the DataGridView
            if (dataGridView.CurrentRow != null)
            {
                // Get the row number clicked
                int rowClicked = dataGridView.CurrentRow.Index;

                // Ensure that the selected row has a value in the specified cell (column index 4)
                if (dataGridView.Rows[rowClicked].Cells[4].Value != null)
                {
                    String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

                    try
                    {
                        // Create a WebClient with a specified User-Agent header
                        using (WebClient webClient = new WebClient())
                        {
                            // Set the User-Agent header to comply with Wikimedia's policy
                            webClient.Headers.Add("User-Agent", "YourAppName/1.0 (your@email.com)");

                            // Load the image using WebClient
                            byte[] data = webClient.DownloadData(imageURL);

                            using (MemoryStream ms = new MemoryStream(data))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }

                            // Assuming albums and Tracks are properly initialized
                            dataGridView2.DataSource = albums[rowClicked].Tracks;
                        }
                    }
                    catch (WebException ex)
                    {
                        // Handle the exception, e.g., log or display an error message
                        MessageBox.Show($"Error loading image: {ex.Message}");
                    }
                }
                else
                {
                    // Handle the case where the cell value is null
                    MessageBox.Show("Selected row does not have a valid image URL.");
                }
            }
            else
            {
                // Handle the case where there is no current row
                MessageBox.Show("No rows available in the DataGridView.");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Adding a new item to the database
            Album album = new Album
            {
                AlbumTitle = Txt_AlbumName.Text,
                ArtistTitle = Txt_Artist.Text,
                YearRelease = Int32.Parse(Txt_Year.Text),
                ImageLink = Txt_ImageURL.Text,
                Summary = Txt_Description.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneAlbum(album);
            MessageBox.Show(result + " new row(s) inserted");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Get the row number clicked
            int rowClicked = dataGridView2.CurrentRow.Index;
            int trackID = (int)dataGridView2.Rows[rowClicked].Cells[0].Value;

            AlbumsDAO albumsDao = new AlbumsDAO();

            int result = albumsDao.deleteTrack(trackID);

            MessageBox.Show("Deleted Successfully");

            dataGridView2.DataSource = null;
            albums = albumsDao.getAllAlbums();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Add2_Click(object sender, EventArgs e)
        {
            // Adding a new item to the database
            Track track = new Track
            {
                Name = Txt_TrackTitle.Text,
                Number = Int32.Parse(Txt_Number.Text),
                VideoURL = Txt_VideoURL.Text,
                Lyrics = Txt_Lyrics.Text,
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.newTrack(track);
            MessageBox.Show(result + " new row(s) inserted");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_AlbumID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditTrack_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView2.CurrentRow.Index;

            Track editing = tracks[rowClicked];
            Txt_TrackTitle.Text = editing.Name;
            Txt_Number.Text = editing.Number.ToString();
            Txt_VideoURL.Text = editing.VideoURL;
            Txt_Lyrics.Text = editing.Lyrics;
            Txt_AlbumID.Text = editing.AlbumID.ToString();
            Edit2.Checked = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;

            Album editMe = albums[rowClicked];
            Txt_AlbumName.Text = editMe.AlbumTitle;
            Txt_Artist.Text = editMe.ArtistTitle;
            Txt_Year.Text = editMe.YearRelease.ToString();
            Txt_ImageURL.Text = editMe.ImageLink;
            Txt_Description.Text = editMe.Summary;

            Edit.Checked = true;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
