namespace NotDefteri
{
    class Program
    {
        static List<string> notes = new List<string>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("1. Not Ekle");
                Console.WriteLine("2. Notları Görüntüle");
                Console.WriteLine("3. Not Sil");
                Console.WriteLine("4. Çıkış");
                Console.Write("Seçiminiz: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddNote();
                        break;
                    case 2:
                        ViewNotes();
                        break;
                    case 3:
                        DeleteNote();
                        break;
                    case 4:
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek.");
                        break;
                }
            } while (choice != 4);
        }

        static void AddNote()
        {
            Console.Write("Yeni notunuzu girin: ");
            string note = Console.ReadLine();
            notes.Add(note);
            Console.WriteLine("Not eklendi.");
        }

        static void ViewNotes()
        {
            Console.WriteLine("Notlar:");
            for (int i = 0; i < notes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {notes[i]}");
            }
        }

        static void DeleteNote()
        {
            Console.Write("Silmek istediğiniz not numarasını girin: ");
            int noteIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (noteIndex >= 0 && noteIndex < notes.Count)
            {
                notes.RemoveAt(noteIndex);
                Console.WriteLine("Not silindi.");
            }
            else
            {
                Console.WriteLine("Geçersiz not numarası.");
            }
        }
    }
}
