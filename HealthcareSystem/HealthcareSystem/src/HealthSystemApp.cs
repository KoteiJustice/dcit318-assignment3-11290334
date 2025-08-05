namespace HealthcareSystem.src
{
    public class HealthSystemApp
    {
        Repository<Patient> _patientRepo = new();
        Repository<Prescription> _prescriptionRepo = new();
        Dictionary<int, List<Prescription>> _prescriptionMap = new();

        public void SeedData()
        {
            _patientRepo.Add(new Patient(1, "Jay", 20, "Male"));
            _patientRepo.Add(new Patient(2, "Kay", 21, "Male"));
            _patientRepo.Add(new Patient(3, "Niikwei", 22, "Male"));

            _prescriptionRepo.Add(new Prescription(001, 1, "Paracetamol", DateTime.Now));
            _prescriptionRepo.Add(new Prescription(002, 2, "Vitamin C", DateTime.Now));
            _prescriptionRepo.Add(new Prescription(003, 3, "Ibuprofen", DateTime.Now));
            _prescriptionRepo.Add(new Prescription(004, 3, "Amoxicillin", DateTime.Now));
        }

        public void BuildPrescriptionMap()
        {
            foreach (var prescription in _prescriptionRepo.GetAll())
            {
                if (!_prescriptionMap.ContainsKey(prescription.PatientId))
                {
                    _prescriptionMap[prescription.PatientId] = new List<Prescription>();
                }
                _prescriptionMap[prescription.PatientId].Add(prescription);
            }
        }

        public void PrintAllPatients()
        {
            foreach (var patient in _patientRepo.GetAll())
            {
                Console.WriteLine("Patient ID: " + patient.Id+ ", Patient name: " + patient.Name + ", Patient gender: " + patient.Gender + " Patient Age: " + patient.Age);
            }
        }
        public void PrintPrescriptionsForPatient(int id)
        {
            var prescriptions = GetPrescriptionsByPatientId(id);
            if (prescriptions.Count == 0)
            {
                Console.WriteLine("No prescriptions found for this patient");
                return;
            }
            foreach (var item in prescriptions)
            {
                Console.WriteLine("Prescription ID: " + item.Id + " Medication: " + item.MedicationName + " Date Issued: " + item.DateIssued);
            }
        }
        public List<Prescription> GetPrescriptionsByPatientId(int patientId)
        {
            return _prescriptionMap.TryGetValue(patientId, out var prescriptions) ? prescriptions : new List<Prescription>();
        }
    }
}