// See https://aka.ms/new-console-template for more information
Console.WriteLine("HCM SYSTEM");
string[] userName = new string[4];
userName[0] = "Alfred";
userName[1] = "Bale";
userName[2] = "Rose";
userName[3] = "James";
string[] passWords = new string[4];
passWords[0] = "26gdbc2";
passWords[1] = "ball24v";
passWords[2] = "24dm3we";
passWords[3] = "35fdacf";
Console.WriteLine("Input Username");
string inputUsername = Convert.ToString(Console.ReadLine());
Console.WriteLine("Input Password");
string inputPassword = Convert.ToString(Console.ReadLine());
if (inputUsername == userName[0] && inputPassword == passWords[0])
{
    Console.WriteLine("Welcome "+ inputUsername);
    PatientDetails();
}
else if (inputUsername == userName[1] && inputPassword == passWords[1])
{
    Console.WriteLine("Welcome " + inputUsername);
     PatientDetails();
}
else if (inputUsername == userName[2] && inputPassword == passWords[2])
{
    Console.WriteLine("Welcome "+ inputUsername);
     PatientDetails();
}
else if (inputUsername == userName[3] && inputPassword == passWords[3])
{
    Console.WriteLine("Welcome "+ inputUsername);
     PatientDetails();
}
else
{
    Console.WriteLine("Wrong Username or Password, Please Retry");
}
//Access to patient Document
void PatientDetails()
{
Console.WriteLine("Input Patient ID to display files");
string[] patientId = new string[10];
patientId[0] = "A1";
patientId[1] = "B2";
patientId[2] = "C1";
patientId[3] = "D1";
patientId[4] = "E1";
patientId[5] = "F1";
patientId[6] = "G1";
patientId[7] = "H1";
patientId[8] = "I1";
patientId[9] = "J1";
string inputPatientId = Convert.ToString(Console.ReadLine());
if (inputPatientId == patientId[0])
{
    Console.WriteLine("This is  patient " + inputPatientId + " file");
    Console.WriteLine("Patient: John Doe");
    Console.WriteLine("Chief Complaint: Persistent headaches and dizziness.");
    Console.WriteLine("History: Mr. Doe reports intermittent, stress-related headaches (6/10 in intensity) and dizziness for two weeks.");
    Console.WriteLine(" Medical History: None significant..");
    Console.WriteLine("Medications: Lisinopril 10mg daily.");

}
else if (inputPatientId == patientId[1])
{
    Console.WriteLine("This is  patient " + inputPatientId + " file");
     Console.WriteLine("Patient: Jane Smith'" );
    Console.WriteLine("Chief Complaint: Abdominal pain and fatigue.");
    Console.WriteLine("History: Ms. Smith presents with recurrent, crampy lower abdominal pain for three weeks, associated with bloating and increased fatigue.");
    Console.WriteLine(" Medical History: None significant.");
    Console.WriteLine("Medications: None reported.");
}
else if (inputPatientId == patientId[2])
{
    Console.WriteLine("This is  patient " + inputPatientId + " file");
    Console.WriteLine("Patient: Lady JAne.");
    Console.WriteLine("Chief Complaint: Persistent vomit and dizziness..");
    Console.WriteLine( "History: Mr. Johnson reports a chronic dry cough lasting for two months, occasionally accompanied by mild chest discomfort.");
    Console.WriteLine("Medications: Amlodipine 5mg daily, Metformin 1000mg twice daily..");
    Console.WriteLine("Medical History: Hypertension, type 2 diabetes.");
}
else if (inputPatientId == patientId[3])
{
    Console.WriteLine("This is  patient " + inputPatientId + " file");
    Console.WriteLine("Patient: Sarah Miller");
    Console.WriteLine("Chief Complaint: Fatigue and joint pain..");
    Console.WriteLine("History: Ms. Miller presents with a three-month history of increasing fatigue and joint pain, particularly in the wrists and knees.");
    Console.WriteLine("Medical History: Rheumatoid arthritis, hypothyroidism.");
    Console.WriteLine("Medications: Methotrexate 10mg weekly, Levothyroxine 75mcg daily.");

}
else if (inputPatientId == patientId[4])
{
    Console.WriteLine("This is  patient " + inputPatientId + " file");
    Console.WriteLine("Patient: Michael Johnson.");
    Console.WriteLine("Chief Complaint: Persistent headaches and visual disturbances.");
    Console.WriteLine("History: Mr. Johnson reports recurrent, severe headaches accompanied by visual disturbances, such as flashing lights and blind spots, lasting for the past two weeks.");
    Console.WriteLine("Medical History: Migraines, hypertension.");
    Console.WriteLine("Medications: Sumatriptan as needed for migraines, Lisinopril 10mg daily.");
}
else if (inputPatientId == patientId[5])
{
    Console.WriteLine("This is  patient " + inputPatientId + " file");
    Console.WriteLine("Patient: Emily Davis");
    Console.WriteLine("Chief Complaint: Shortness of breath and chest pain..");
    Console.WriteLine("History: Ms. Davis presents with acute onset of shortness of breath and sharp chest pain that started yesterday evening.");
    Console.WriteLine("Medical History: Asthma, anxiety disorder.");
    Console.WriteLine("Medications: Albuterol inhaler as needed, sertraline 50mg daily.");
}
else if (inputPatientId == patientId[6])
{
    Console.WriteLine("This is  patient " + inputPatientId + " file");
    Console.WriteLine("Patient: Olivia Taylor");
    Console.WriteLine("Chief Complaint: Abdominal pain and nausea.");
    Console.WriteLine("History: Ms. Taylor presents with sudden-onset severe abdominal pain in the lower right quadrant, associated with nausea and vomiting for the past 12 hours.");
    Console.WriteLine("Medical History: None significant.");
    Console.WriteLine(" Medications: None reported.");
    Console.WriteLine("Social History: Non-smoker, occasional alcohol, student.");

}
else if (inputPatientId == patientId[7])
{
    Console.WriteLine("This is  patient " + inputPatientId + " file");
    Console.WriteLine("Patient: Sophia Rodriguez");
    Console.WriteLine("Chief Complaint: Persistent cough and fever.");
    Console.WriteLine("History: Ms. Rodriguez presents with a cough lasting for two weeks, accompanied by a low-grade fever, fatigue, and occasional shortness of breath.");
    Console.WriteLine("Medical History: Allergic rhinitis.");
    Console.WriteLine("Medications: Over-the-counter antihistamines as needed.");
    Console.WriteLine("Social History: Non-smoker, no alcohol, marketing manager.");

}
else if (inputPatientId == patientId[8])
{
    Console.WriteLine("This is  patient " + inputPatientId + " file");
    Console.WriteLine("Patient: David Wilson");
    Console.WriteLine("Chief Complaint: Joint pain and fatigue.");
    Console.WriteLine("History: Mr. Wilson reports a six-month history of persistent joint pain, stiffness, and increasing fatigue, particularly in the wrists and knees.");
    Console.WriteLine("Medical History: Hypertension, osteoarthritis.");
    Console.WriteLine("Medications: Lisinopril 20mg daily, occasional over-the-counter pain relievers.");
    Console.WriteLine("Social History: Non-smoker, no alcohol, retired teacher.");

}
else if (inputPatientId == patientId[9])
{
    Console.WriteLine("This is  patient " + inputPatientId + " file");
    Console.WriteLine("Patient: Emma Harris");
    Console.WriteLine("Chief Complaint: Fever and sore throat.");
    Console.WriteLine("History: Ms. Harris presents with a three-day history of fever, sore throat, and difficulty swallowing.");
    Console.WriteLine("Medical History: None significant.");
    Console.WriteLine("Medications: None reported.");
    Console.WriteLine("Social History: Non-smoker, no alcohol, college student.");

}
else
{
    Console.WriteLine("Wrong Id");
    Console.WriteLine("No Data Found");
}
}
Console.WriteLine("Press any key to close the Aplication");
Console.ReadKey();