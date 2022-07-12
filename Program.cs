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



using (EcommerceContext db = new EcommerceContext())
{
    Products newProduct = new Products { Name = "Libro", Price = 12 };
    Products newProduct1 = new Products { Name = "Cuscino", Price = 9 };
    Products newProduct2 = new Products { Name = "Computer", Price = 345 };

    db.Add(newProduct);
    db.Add(newProduct1);
    db.Add(newProduct2);
    db.SaveChanges();


}


