﻿using HealthCareApp.model;
using MySql.Data.MySqlClient;

namespace HealthCareApp.DAL
{
    public class VisitDal
    {
        public static void CreateVisit(Visit newVisit)
        {
            string query = "INSERT INTO visit (appointment_id, nurse_id, bp_systolic, bp_diastolic, body_temperature, weight, height, pulse_rate, symptoms, initial_diagnosis, final_diagnosis) " +
                           "VALUES (@AppointmentId, @NurseId, @BloodPressureSys, @BloodPressureDias, @BodyTemp, @Weight, @Height, @PulseRate, @Symptoms, @InitialDiag, @FinalDiag)";

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();
            using MySqlCommand command = new MySqlCommand(query, connection);

            AddAllVisitParamsToCommand(newVisit, command);
            
            command.ExecuteNonQuery();
        }

        public static List<Visit> GetAllVisits()
        {
            string query = "SELECT * FROM visit";

            using var connection = new MySqlConnection(Connection.ConnectionString());
            connection.Open();

            using MySqlCommand command = new MySqlCommand(query, connection);
            using MySqlDataReader reader = command.ExecuteReader();

            var visitList = new List<Visit>();
            while (reader.Read())
            {
                visitList.Add(
                    CreateVisitObj(reader));
            }

            return visitList;
        }

        private static Visit CreateVisitObj(MySqlDataReader reader)
        {
            var visitIdOrdinal= reader.GetOrdinal("visit_id");
            var appointmentIdOrdinal= reader.GetOrdinal("appointment_id");
            var nurseIdOrdinal = reader.GetOrdinal("nurse_id");
            var bloodPressureSysOrdinal = reader.GetOrdinal("bp_systolic");
            var bloodPressureDiasOrdinal = reader.GetOrdinal("bp_diastolic");
            var bodyTempOrdinal = reader.GetOrdinal("body_temperature");
            var weightOrdinal = reader.GetOrdinal("weight");
            var heightOrdinal = reader.GetOrdinal("height");
            var pulseRateOrdinal = reader.GetOrdinal("pulse_rate");
            var symptomsOrdinal= reader.GetOrdinal("symptoms");
            var initialDiagOrdinal= reader.GetOrdinal("initial_diagnosis");
            var finalDiagOrdinal = reader.GetOrdinal("final_diagnosis");

            var newVisit = new Visit
            (
                reader.GetInt32(visitIdOrdinal),
                reader.GetInt32(appointmentIdOrdinal),
                reader.GetInt32(nurseIdOrdinal),
                reader.GetInt32(bloodPressureSysOrdinal),
                reader.GetInt32(bloodPressureDiasOrdinal),
                reader.GetDecimal(bodyTempOrdinal),
                reader.GetDecimal(weightOrdinal),
                reader.GetDecimal(heightOrdinal),
                reader.GetInt32(pulseRateOrdinal),
                reader.GetString(symptomsOrdinal),
                reader.GetString(initialDiagOrdinal),
                reader.IsDBNull(finalDiagOrdinal) ? null : reader.GetString(finalDiagOrdinal)
            );

            return newVisit;
        }

        private static void AddAllVisitParamsToCommand(Visit newVisit, MySqlCommand command)
        {
            command.Parameters.Add("@AppointmentId", MySqlDbType.Int32).Value = newVisit.AppointmentId;
            command.Parameters.Add("@NurseId", MySqlDbType.Int32).Value = newVisit.NurseId;
            command.Parameters.Add("@BloodPressureSys", MySqlDbType.Int32).Value = newVisit.BloodPressureSystolic;
            command.Parameters.Add("@BloodPressureDias", MySqlDbType.Int32).Value = newVisit.BloodPressureDiastolic;
            command.Parameters.Add("@BodyTemp", MySqlDbType.Decimal).Value = newVisit.BodyTemp;
            command.Parameters.Add("@Weight", MySqlDbType.Decimal).Value = newVisit.Weight;
            command.Parameters.Add("@Height", MySqlDbType.Decimal).Value = newVisit.Height;
            command.Parameters.Add("@PulseRate", MySqlDbType.Int32).Value = newVisit.PulseRate;
            command.Parameters.Add("@Symptoms", MySqlDbType.VarChar).Value = newVisit.Symptoms;
            command.Parameters.Add("@InitialDiag", MySqlDbType.VarChar).Value = newVisit.InitialDiagnoses;
            command.Parameters.Add("@FinalDiag", MySqlDbType.VarChar).Value = newVisit.FinalDiagnoses;

        }
    }
}