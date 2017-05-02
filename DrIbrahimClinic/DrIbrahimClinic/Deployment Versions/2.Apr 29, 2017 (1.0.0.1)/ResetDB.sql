DELETE ExaminationTreatment
GO
DBCC CHECKIDENT('ExaminationTreatment', RESEED, 0);
GO
DELETE ExaminationDiagnosis
GO
DBCC CHECKIDENT('ExaminationDiagnosis', RESEED, 0);
GO
DELETE MedicalHistory
GO
DBCC CHECKIDENT('MedicalHistory', RESEED, 0);
GO
DELETE Inoculations
GO
DBCC CHECKIDENT('Inoculations', RESEED, 0);
GO
DELETE Examinations
GO
DBCC CHECKIDENT('Examinations', RESEED, 0);
GO
DELETE Patients
GO
DBCC CHECKIDENT('Patients', RESEED, 0);
GO
DELETE Diagnosis
GO
DBCC CHECKIDENT('Diagnosis', RESEED, 0);
GO
DELETE Treatments
GO
DBCC CHECKIDENT('Treatments', RESEED, 0);
GO
DELETE TreatmentsDescription
GO
DBCC CHECKIDENT('TreatmentsDescription', RESEED, 0);
GO
