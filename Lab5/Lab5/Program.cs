using Lab5.Doctors;

List<string> materialUsed = new List<string>() { "Seal", "glue", "crown" };

Dentist dentist = new Dentist("Robert Johnson", 100000, 8, materialUsed);
dentist.DisplayInfo();

PlasticSurgeon psurgeon = new PlasticSurgeon("Emily Johnson", 100000, 4, true, 287);
psurgeon.DisplayInfo();

Neurosurgeon nsurgeon = new Neurosurgeon("Tom Potter", 100000, 12, true, "High");
nsurgeon.DisplayInfo();


// Add services offered by the dentist
dentist.AddService(new DentalService("Cleaning", 100));
dentist.AddService(new DentalService("Filling", 200));
dentist.AddService(new DentalService("Whitening", 300));

// List of services a client received
List<DentalService> servicesReceived = new List<DentalService>
    {
        new DentalService("Cleaning", 100),
        new DentalService("Whitening", 300)
    };

// Calculate and display the total payment for services received
double totalPayment = dentist.CalculatePayment(servicesReceived);
Console.WriteLine($"Total payment for dental services: ${totalPayment}");


Console.ReadKey();