using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDAL.DBManager
{
    public class SqlQueries
    {
        #region Patients
        public static string GetAllPatients = "SELECT * FROM Patient";
        public static string GetPatientById = "SELECT * FROM Patient WHERE patientId = @patientId";
        public static string AddPatient = "INSERT INTO Patient (name, gender, address, contact, email, doctorId, photo) VALUES (@name, @gender, @address, @contact, @email, @doctorId, @photo)";
        public static string UpdatePatient = "UPDATE Patient SET name = @name, gender = @gender, address = @address, contact = @contact, email = @email, doctorId = @doctorId, photo = @photo WHERE patientId = @patientId";
        public static string DeletePatient = "DELETE FROM Patient WHERE patientId = @patientId";
        public static string GetFilteredPatients = "EXEC SP_GetFilteredPatientList @name,@contact,@email, @gender,@doctorId";
        public static string GetPatientNameAndId = "EXEC SP_GetPatientNameAndId";

        #endregion

        #region Doctors
        public static string GetAllDoctors = "SELECT * FROM Doctor";
        public static string GetDoctorById = "SELECT * FROM Doctor WHERE dId = @dId";
        public static string AddDoctor = "INSERT INTO Doctor (name, contact, address, email, gender) VALUES (@name, @contact, @address, @email, @gender)";
        public static string UpdateDoctor = "UPDATE Doctor SET dName = @dName, dGender = @dGender, dAddress = @dAddress, dPhone = @dPhone, dEmail = @dEmail, dSpecialization = @dSpecialization, photo = @photo WHERE dId = @dId";
        public static string DeleteDoctor = "DELETE FROM Doctor WHERE dId = @dId";
        public static string Vw_GetDoctorList = "SELECT doctorid,name FROM vw_DoctorsList";
        public static string Sp_GetFilteredDoctors = "EXEC SP_GetFilteredDoctorList @name,@contact,@address,@email, @gender";
        #endregion

        #region Appointments
        public static string GetAllAppointments = "SELECT * FROM Appointment";
        public static string GetAppointmentById = "SELECT * FROM Appointment WHERE aId = @aId";
        public static string AddAppointment = "INSERT INTO Appointment (aDate, aTime, aPatientId, aDoctorId) VALUES (@aDate, @aTime, @aPatientId, @aDoctorId)";
        public static string UpdateAppointment = "UPDATE Appointment SET aDate = @aDate, aTime = @aTime, aPatientId = @aPatientId, aDoctorId = @aDoctorId WHERE aId = @aId";
        public static string DeleteAppointment = "DELETE FROM Appointment WHERE aId = @aId";

        #endregion

        #region Diseases
        public static string GetAllDiseases = "SELECT * FROM Disease";
        public static string GetDiseaseById = "SELECT * FROM Disease WHERE dId = @dId";
        public static string AddDisease = "INSERT INTO Disease (dName, dDescription) VALUES (@dName, @dDescription)";
        public static string UpdateDisease = "UPDATE Disease SET dName = @dName, dDescription = @dDescription WHERE dId = @dId";
        public static string DeleteDisease = "DELETE FROM Disease WHERE dId = @dId";
        #endregion

        #region Medicines
        public static string GetAllMedicines = "SELECT * FROM Medicine";
        public static string GetMedicineById = "SELECT * FROM Medicine WHERE mId = @mId";
        public static string AddMedicine = "INSERT INTO Medicine (mName, mDescription) VALUES (@mName, @mDescription)";
        public static string UpdateMedicine = "UPDATE Medicine SET mName = @mName, mDescription = @mDescription WHERE mId = @mId";
        public static string DeleteMedicine = "DELETE FROM Medicine WHERE mId = @mId";
        #endregion

        #region PatientDiseases
        public static string GetAllPatientDiseases = "SELECT * FROM PatientDisease";
        public static string GetPatientDiseaseById = "SELECT * FROM PatientDisease WHERE pdId = @pdId";
        public static string AddPatientDisease = "INSERT INTO PatientDisease (pdPatientId, pdDiseaseId) VALUES (@pdPatientId, @pdDiseaseId)";
        public static string UpdatePatientDisease = "UPDATE PatientDisease SET pdPatientId = @pdPatientId, pdDiseaseId = @pdDiseaseId WHERE pdId = @pdId";
        public static string DeletePatientDisease = "DELETE FROM PatientDisease WHERE pdId = @pdId";
        #endregion

        #region PatientVisit
        public static string GetFilteredPatientVisitList = "SELECT * FROM PatientVisit";


        #endregion
        #region Fees
        public static string GetFees = "SELECT * FROM Fees";


        #endregion

        #region File Location Management
        public static string GetAllFileLocation = "SELECT * FROM FileLocation";
        public static string GetFileLocationById = "SELECT * FROM FileLocation WHERE flId = @flId";
        public static string DeleteFileLocation = "DELETE FROM FileLocation WHERE flId = @flId";
        public static string QueryAddNewFileLocation = "INSERT INTO FileLocation (FileName, PhysicalPath, LastUpdated, Description) VALUES (@FileName, @PhysicalPath, @LastUpdated, @Description)";
        public static string QueryUpdateFileLocation = "UPDATE FileLocation SET FileName=@FileName, PhysicalPath=@PhysicalPath, LastUpdated=@LastUpdated, Description=@Description) WHERE flId = @flId";
        #endregion

    }
}
