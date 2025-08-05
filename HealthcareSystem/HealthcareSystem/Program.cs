using HealthcareSystem.src;

public class Program
{
    static void Main()
    {
        HealthSystemApp health = new HealthSystemApp();
        health.SeedData();
        health.BuildPrescriptionMap();
        health.PrintAllPatients();
        health.PrintPrescriptionsForPatient(3);
        
    }
}