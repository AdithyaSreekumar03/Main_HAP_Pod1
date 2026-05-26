using HealthApp.Model;

public interface IPatientRepository
{
    void Add(Patient patient);

    List<Patient> GetAll();

    Patient? GetById(int id);

    Patient? UpdatePatientById(int id, Patient patient);

    Patient? DeletePatientById(int id);
}


