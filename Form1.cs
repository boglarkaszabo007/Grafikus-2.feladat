namespace Grafikus_2.feladat
{
    public partial class Form1 : Form
    {
        private List<Book> books;

        public Form1()
        {
            InitializeComponent();
             // A Form1 inicializálásával kapcsolatos feladatok

            // Feladat: 2
            // Összes könyv számának megjelenítése
            int totalBooksCount = books.Count;
            Label totalBooksLabel = new Label();
            totalBooksLabel.Text = $"Összes könyv száma: {totalBooksCount}";
            totalBooksLabel.Font = new Font(FontFamily.GenericSansSerif, 12);
            totalBooksLabel.Location = new Point(10, 10);
            this.Controls.Add(totalBooksLabel);

            // Feladat: 3
            // Táblázat létrehozása és feltöltése
            DataGridView table = new DataGridView();
            table.Location = new Point(10, 40);
            table.Size = new Size(600, 300);
            table.ColumnCount = 3;
            table.Columns[0].Name = "Kategória";
            table.Columns[1].Name = "Cím";
            table.Columns[2].Name = "Ár";
            foreach (Book book in books)
            {
                table.Rows.Add(book.Kategoria, book.Cim, book.Ar.ToString("C"));
            }
            this.Controls.Add(table);

            // Feladat: 4
            // Legdrágább könyv(ek) megjelenítése
            table.CellContentClick += dataGridView1_CellContentClick;

            // Feladat: 5
            // Könyv kategóriák megjelenítése
            ComboBox categoryComboBox = new ComboBox();
            categoryComboBox.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            categoryComboBox.Location = new Point(10, 400);
            categoryComboBox.Size = new Size(200, 30);
            categoryComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            categoryComboBox.Items.AddRange(books.Select(b => b.Kategoria).Distinct().ToArray());
            this.Controls.Add(categoryComboBox);

            // Feladat: 6
            // Háttérszín beállítása és az ablak címe
            this.Text = "Könyvek";
            this.BackColor = Color.Brown;
        }


        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedCategory = comboBox.SelectedItem.ToString();
            var selectedBooks = books.Where(b => b.Kategoria == selectedCategory);
            string selectedBooksText = $"Választott kategóriában lévő könyvek:\n";
            foreach (var book in selectedBooks)
            {
                selectedBooksText += $"Cím: {book.Cim}, Ár: {book.Ar.ToString("C")}, Darabszám: {book.Darabszam}\n";
            }
            MessageBox.Show(selectedBooksText);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var mostExpensiveBooks = books.GroupBy(b => b.Ar)
                                           .OrderByDescending(g => g.Key)
                                           .First();
            string mostExpensiveBooksText = "Legdrágább könyv(ek):\n";
            foreach (var book in mostExpensiveBooks)
            {
                mostExpensiveBooksText += $"Kategória: {book.Kategoria}, Cím: {book.Cim}, Ár: {book.Ar.ToString("C")}\n";
            }
            MessageBox.Show(mostExpensiveBooksText);
            
        }
        private void InitializeForm()
        {
           
        }
    }
}
