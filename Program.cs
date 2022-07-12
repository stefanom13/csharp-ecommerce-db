//Si realizzi un prototipo di un e-commerce con approccio
//code-first usando Entity Framework seguendo lo schema allegato.
//Si consideri la possibilità di poter verificare la bontà del prototipo
//eseguendo alcune operazioni di CRUD sul sistema:

//*inserire almeno 3 prodotti diversi
//*inserire almeno 5 ordini su almeno 2 utenti diversi
//*recuperare la lista di tutti gli ordini effettuati da un cliente
//*modificare l’ordine di un cliente
//*cancellare un ordine di un cliente
//*cancellare un prodotto su cui è attivo almeno un ordine



//using (SchoolContext db = new SchoolContext())
//{
// Create
//Student nuovoStudente = new Student { Name = "Francesco" }
//db.Add(nuovoStudente);
//db.SaveChanges();

// Read
//// List<Student> students = db.Students.OrderBy(student => student.Name).ToList<Student>();

// Update
//nuovoStudente.Name = "Veronica";
//db.SaveChanges();

// Delete
//db.Remove(student);
//db.SaveChanges();
//}

using csharp_ecommerce_db;

internal class Program
{
    static void Main(string[] args)
    {
        using (EcommerceContext db = new EcommerceContext())
        {
            Products newProduct = new Products { Name = "Libro", Price = 12 };
            Products newProduct1 = new Products { Name = "Cuscino", Price = 9 };
            Products newProduct2 = new Products { Name = "Computer", Price = 345 };

            db.Add(newProduct);
            db.Add(newProduct1);
            db.Add(newProduct2);
            db.SaveChanges();

            // Creazione Customer

            Customers newCust = new Customers("Stefano", "Mancuso", "stfmncs@gmail.com");
            Customers newCust1 = new Customers("Gianni", "Renda", "girenda@gmail.com");

            db.Add(newCust);
            db.Add(newCust1);
            db.SaveChanges();

            // *** Creazione ordini
            Orders order1 = new Orders(5, DateTime.Now, true);
            Orders order2 = new Orders(3, DateTime.Now, false);
            Orders order3 = new Orders(3, DateTime.Now, true);
            Orders order4 = new Orders(5, DateTime.Now, true);
            Orders order5 = new Orders(5, DateTime.Now, false);


            db.Add(order1);
            db.Add(order2);
            db.Add(order3);
            db.Add(order4);
            db.Add(order5);
            db.SaveChanges();

        }
    }
       
}





