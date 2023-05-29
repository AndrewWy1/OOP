using Microsoft.EntityFrameworkCore;
using Hospital.Data.Models;
using Microsoft.EntityFrameworkCore.Internal;

namespace Hospital.Data
{
	public class HospitalContext : DbContext
	{
		public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
		{ }

		public DbSet<Medicament> Medicaments { get; set; }
		public DbSet<Patient> Patients { get; set; }
		public DbSet<Diagnose> Diagnoses { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet <Visitation> Visitations { get; set; }
		public DbSet <PatientMedicament> PatientMedicaments { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//many-many PatientMedicament
			modelBuilder.Entity<PatientMedicament>()
						.HasKey(pm => new { pm.PatientId, pm.MedicamentId });

			modelBuilder.Entity<PatientMedicament>()
						.HasOne(pm => pm.Patient)
						.WithMany(p => p.PatientMedicaments)
						.HasForeignKey(pm => pm.PatientId);

			modelBuilder.Entity<PatientMedicament>()
						.HasOne(pm => pm.Medicament)
						.WithMany(m => m.PatientMedicaments)
						.HasForeignKey(pm => pm.MedicamentId);


			//many-many Visitation
			modelBuilder.Entity<Visitation>()
						.HasOne(v => v.Patient)
						.WithMany(p => p.Visitations)
						.HasForeignKey(v => v.PatientId);

			modelBuilder.Entity<Visitation>()
						.HasOne(v => v.Doctor)
						.WithMany(d => d.Visitations)
						.HasForeignKey(v => v.DoctorId);
		}
	}
}
