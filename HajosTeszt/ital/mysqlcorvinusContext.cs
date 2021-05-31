using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class mysqlcorvinusContext : DbContext
    {
        public mysqlcorvinusContext()
        {
        }

        public mysqlcorvinusContext(DbContextOptions<mysqlcorvinusContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abc123Tanar> Abc123Tanars { get; set; }
        public virtual DbSet<Abc123Tankonyv> Abc123Tankonyvs { get; set; }
        public virtual DbSet<AsdasdVszoba> AsdasdVszobas { get; set; }
        public virtual DbSet<Beosztasok> Beosztasoks { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<Diak> Diaks { get; set; }
        public virtual DbSet<Dvd> Dvds { get; set; }
        public virtual DbSet<Employment> Employments { get; set; }
        public virtual DbSet<Foglala> Foglalas { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Ital> Itals { get; set; }
        public virtual DbSet<Italok> Italoks { get; set; }
        public virtual DbSet<Kai0ymTanar> Kai0ymTanars { get; set; }
        public virtual DbSet<Kai0ymTanarTk> Kai0ymTanarTks { get; set; }
        public virtual DbSet<Kai0ymTankönyv> Kai0ymTankönyvs { get; set; }
        public virtual DbSet<Kai0ymVvendeghazSzobak> Kai0ymVvendeghazSzobaks { get; set; }
        public virtual DbSet<Kolcsonzesek> Kolcsonzeseks { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Munka> Munkas { get; set; }
        public virtual DbSet<Munkaado> Munkaados { get; set; }
        public virtual DbSet<Napok> Napoks { get; set; }
        public virtual DbSet<Nyelvek> Nyelveks { get; set; }
        public virtual DbSet<Oktatok> Oktatoks { get; set; }
        public virtual DbSet<Orak> Oraks { get; set; }
        public virtual DbSet<Raktar> Raktars { get; set; }
        public virtual DbSet<Rendele> Rendeles { get; set; }
        public virtual DbSet<RendelesTetel> RendelesTetels { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Savok> Savoks { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Statusok> Statusoks { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Szallashely> Szallashelies { get; set; }
        public virtual DbSet<Szoba> Szobas { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<TableName> TableNames { get; set; }
        public virtual DbSet<Tagok> Tagoks { get; set; }
        public virtual DbSet<Tantárgyak> Tantárgyaks { get; set; }
        public virtual DbSet<Termek> Termeks { get; set; }
        public virtual DbSet<Termekkategorium> Termekkategoria { get; set; }
        public virtual DbSet<Termék> Terméks { get; set; }
        public virtual DbSet<Termékkategorium> Termékkategoria { get; set; }
        public virtual DbSet<Tesztfej> Tesztfejs { get; set; }
        public virtual DbSet<Teszttetel> Teszttetels { get; set; }
        public virtual DbSet<Time> Times { get; set; }
        public virtual DbSet<Ugyfel> Ugyfels { get; set; }
        public virtual DbSet<Vendeg> Vendegs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=kai0ym-covinus.database.windows.net;Initial Catalog=mysql-corvinus;Persist Security Info=True;User ID=kai0ym;Password=3337305Bp1237");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hungarian_CI_AS");

            modelBuilder.Entity<Abc123Tanar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ABC123_TANAR");

                entity.Property(e => e.Beosztás).HasColumnName("beosztás");

                entity.Property(e => e.Nev)
                    .HasMaxLength(50)
                    .HasColumnName("nev");

                entity.Property(e => e.OktatoId).HasColumnName("oktato_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Titulus)
                    .HasMaxLength(50)
                    .HasColumnName("titulus");
            });

            modelBuilder.Entity<Abc123Tankonyv>(entity =>
            {
                entity.HasKey(e => e.Tkod)
                    .HasName("PK__ABC123_T__F8375A52DD0AE16A");

                entity.ToTable("ABC123_TANKONYV");

                entity.Property(e => e.Tkod).ValueGeneratedNever();

                entity.Property(e => e.Tcim)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsdasdVszoba>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("asdasd_vszoba");

                entity.Property(e => e.CsillagokSzama).HasColumnName("CSILLAGOK_SZAMA");

                entity.Property(e => e.Ferohely).HasColumnName("FEROHELY");

                entity.Property(e => e.Hely)
                    .HasMaxLength(20)
                    .HasColumnName("hely");

                entity.Property(e => e.Klimas)
                    .HasMaxLength(1)
                    .HasColumnName("KLIMAS");

                entity.Property(e => e.Potagy).HasColumnName("POTAGY");

                entity.Property(e => e.SzallasFk).HasColumnName("SZALLAS_FK");

                entity.Property(e => e.SzallasNev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SZALLAS_NEV");

                entity.Property(e => e.SzobaId).HasColumnName("SZOBA_ID");

                entity.Property(e => e.SzobaSzama)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("SZOBA_SZAMA");
            });

            modelBuilder.Entity<Beosztasok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Beosztasok");

                entity.Property(e => e.BeosztasId).HasColumnName("beosztas_id");

                entity.Property(e => e.Beosztasnev)
                    .HasMaxLength(50)
                    .HasColumnName("beosztasnev");

                entity.Property(e => e.Elvart).HasColumnName("elvart");
            });

            modelBuilder.Entity<Day>(entity =>
            {
                entity.ToTable("Day");

                entity.Property(e => e.DayId)
                    .ValueGeneratedNever()
                    .HasColumnName("DayID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Diak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("diak");

                entity.Property(e => e.Nev).HasMaxLength(50);

                entity.Property(e => e.Szulido).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dvd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dvd");

                entity.Property(e => e.Cim)
                    .HasMaxLength(255)
                    .HasColumnName("cim");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lang).HasColumnName("lang");

                entity.Property(e => e.Nettoar).HasColumnName("nettoar");

                entity.Property(e => e.RaktárKészlet).HasColumnName("raktár készlet");

                entity.Property(e => e.Stilus)
                    .HasMaxLength(255)
                    .HasColumnName("stilus");

                entity.Property(e => e.Szam)
                    .HasMaxLength(255)
                    .HasColumnName("szam");
            });

            modelBuilder.Entity<Employment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employment");

                entity.Property(e => e.EmploymentId)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EmploymentID")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Foglala>(entity =>
            {
                entity.HasKey(e => e.FoglalasPk);

                entity.Property(e => e.FoglalasPk)
                    .ValueGeneratedNever()
                    .HasColumnName("FOGLALAS_PK");

                entity.Property(e => e.FelnottSzam).HasColumnName("FELNOTT_SZAM");

                entity.Property(e => e.GyermekSzam).HasColumnName("GYERMEK_SZAM");

                entity.Property(e => e.Meddig)
                    .HasColumnType("date")
                    .HasColumnName("MEDDIG");

                entity.Property(e => e.Mettol)
                    .HasColumnType("date")
                    .HasColumnName("METTOL");

                entity.Property(e => e.SzobaFk).HasColumnName("SZOBA_FK");

                entity.Property(e => e.UgyfelFk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("UGYFEL_FK");

                entity.HasOne(d => d.SzobaFkNavigation)
                    .WithMany(p => p.Foglalas)
                    .HasForeignKey(d => d.SzobaFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foglalas_Szoba");

                entity.HasOne(d => d.UgyfelFkNavigation)
                    .WithMany(p => p.Foglalas)
                    .HasForeignKey(d => d.UgyfelFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foglalas_Vendeg");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey(e => e.InstructorSk)
                    .HasName("PK__tmp_ms_x__9D017A2876F4A95A");

                entity.ToTable("Instructor");

                entity.Property(e => e.InstructorSk).HasColumnName("InstructorSK");

                entity.Property(e => e.EmploymentFk)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("EmploymentFK")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusFk).HasColumnName("StatusFK");

                entity.HasOne(d => d.StatusFkNavigation)
                    .WithMany(p => p.Instructors)
                    .HasForeignKey(d => d.StatusFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Instructor_Status");
            });

            modelBuilder.Entity<Ital>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ital");

                entity.HasIndex(e => e.ItalNev, "UQ__Ital__6A6017AA9ED6313C")
                    .IsUnique();

                entity.Property(e => e.ItalNev)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Italok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Italok");

                entity.Property(e => e.ItalNev)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Kai0ymTanar>(entity =>
            {
                entity.HasKey(e => e.OktatoId)
                    .HasName("NN_KAI0YM_TANAR");

                entity.ToTable("KAI0YM_TANAR");

                entity.HasIndex(e => e.Nev, "UQNEV")
                    .IsUnique();

                entity.Property(e => e.OktatoId)
                    .ValueGeneratedNever()
                    .HasColumnName("oktato_id");

                entity.Property(e => e.Beosztás).HasColumnName("beosztás");

                entity.Property(e => e.Nev)
                    .HasMaxLength(50)
                    .HasColumnName("nev");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Titulus)
                    .HasMaxLength(50)
                    .HasColumnName("titulus")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vegzettseg)
                    .HasMaxLength(2)
                    .HasColumnName("VEGZETTSEG")
                    .HasDefaultValueSql("('E')");
            });

            modelBuilder.Entity<Kai0ymTanarTk>(entity =>
            {
                entity.HasKey(e => e.Ttkkod)
                    .HasName("PK__KAI0YM_T__FE3723CCB70B9DEF");

                entity.ToTable("KAI0YM_TANAR_TK");

                entity.Property(e => e.Ttkkod)
                    .ValueGeneratedNever()
                    .HasColumnName("ttkkod");

                entity.Property(e => e.Tkod).HasColumnName("tkod");

                entity.Property(e => e.Ttkod).HasColumnName("ttkod");

                entity.HasOne(d => d.TkodNavigation)
                    .WithMany(p => p.Kai0ymTanarTks)
                    .HasForeignKey(d => d.Tkod)
                    .HasConstraintName("FK__KAI0YM_TAN__tkod__603D47BB");
            });

            modelBuilder.Entity<Kai0ymTankönyv>(entity =>
            {
                entity.HasKey(e => e.Tkod)
                    .HasName("PK__KAI0YM_T__F8375A52C6EBBB36");

                entity.ToTable("KAI0YM_TANKÖNYV");

                entity.Property(e => e.Tkod).ValueGeneratedNever();

                entity.Property(e => e.AkkreditaltE1)
                    .HasColumnName("akkreditalt_e")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Akkreditalte)
                    .HasColumnName("akkreditalte")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tcim)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tegysegar).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Kai0ymVvendeghazSzobak>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KAI0YM_VVendeghazSzobak");

                entity.Property(e => e.Ferohely).HasColumnName("FEROHELY");

                entity.Property(e => e.Klimas)
                    .HasMaxLength(1)
                    .HasColumnName("KLIMAS");

                entity.Property(e => e.Potagy).HasColumnName("POTAGY");

                entity.Property(e => e.SzallasFk).HasColumnName("SZALLAS_FK");

                entity.Property(e => e.SzobaId).HasColumnName("SZOBA_ID");

                entity.Property(e => e.SzobaSzama)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("SZOBA_SZAMA");
            });

            modelBuilder.Entity<Kolcsonzesek>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kolcsonzesek");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ki).HasColumnName("ki");

                entity.Property(e => e.KiDatum)
                    .HasColumnType("date")
                    .HasColumnName("ki_datum");

                entity.Property(e => e.Mit).HasColumnName("mit");

                entity.Property(e => e.VisszaDatum)
                    .HasColumnType("date")
                    .HasColumnName("vissza_datum");
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.HasKey(e => e.LessonSk)
                    .HasName("PK__tmp_ms_x__B08512E267C81348");

                entity.ToTable("Lesson");

                entity.Property(e => e.LessonSk).HasColumnName("LessonSK");

                entity.Property(e => e.DayFk).HasColumnName("DayFK");

                entity.Property(e => e.InstructorFk).HasColumnName("InstructorFK");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.RoomFk).HasColumnName("RoomFK");

                entity.Property(e => e.TimeFk).HasColumnName("TimeFK");

                entity.HasOne(d => d.DayFkNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.DayFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lesson_Day");

                entity.HasOne(d => d.InstructorFkNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.InstructorFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lesson_Instructor");

                entity.HasOne(d => d.RoomFkNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.RoomFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lesson_Room");

                entity.HasOne(d => d.TimeFkNavigation)
                    .WithMany(p => p.Lessons)
                    .HasForeignKey(d => d.TimeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lesson_Time");
            });

            modelBuilder.Entity<Munka>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("munka");

                entity.Property(e => e.Allas)
                    .HasMaxLength(50)
                    .HasColumnName("allas");

                entity.Property(e => e.Datum)
                    .HasColumnType("datetime")
                    .HasColumnName("datum");

                entity.Property(e => e.Kozepiskolas).HasColumnName("kozepiskolas");

                entity.Property(e => e.MunkaId).HasColumnName("munkaId");

                entity.Property(e => e.Oradij).HasColumnName("oradij");

                entity.Property(e => e.Oraszam).HasColumnName("oraszam");
            });

            modelBuilder.Entity<Munkaado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("munkaado");

                entity.Property(e => e.MhelyId).HasColumnName("MHelyID");

                entity.Property(e => e.MunkaadoNev)
                    .HasMaxLength(50)
                    .HasColumnName("Munkaado_nev");

                entity.Property(e => e.Telepules).HasMaxLength(50);
            });

            modelBuilder.Entity<Napok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Napok");

                entity.Property(e => e.Nap)
                    .HasMaxLength(50)
                    .HasColumnName("nap");

                entity.Property(e => e.NapId).HasColumnName("nap_id");
            });

            modelBuilder.Entity<Nyelvek>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nyelvek");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lang)
                    .HasMaxLength(255)
                    .HasColumnName("lang");
            });

            modelBuilder.Entity<Oktatok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Oktatok");

                entity.Property(e => e.Beosztás).HasColumnName("beosztás");

                entity.Property(e => e.Nev)
                    .HasMaxLength(50)
                    .HasColumnName("nev");

                entity.Property(e => e.OktatoId).HasColumnName("oktato_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Titulus)
                    .HasMaxLength(50)
                    .HasColumnName("titulus");
            });

            modelBuilder.Entity<Orak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orak");

                entity.Property(e => e.Nap).HasColumnName("nap");

                entity.Property(e => e.OraId).HasColumnName("ora_id");

                entity.Property(e => e.Tanar).HasColumnName("tanar");

                entity.Property(e => e.Targy).HasColumnName("targy");

                entity.Property(e => e.Terem).HasColumnName("terem");
            });

            modelBuilder.Entity<Raktar>(entity =>
            {
                entity.HasKey(e => e.RaktarKod);

                entity.ToTable("Raktar");

                entity.Property(e => e.RaktarKod)
                    .ValueGeneratedNever()
                    .HasColumnName("RAKTAR_KOD");

                entity.Property(e => e.RaktarCim)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("RAKTAR_CIM");

                entity.Property(e => e.RaktarNev)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("RAKTAR_NEV");
            });

            modelBuilder.Entity<Rendele>(entity =>
            {
                entity.HasKey(e => e.Sorszam);

                entity.Property(e => e.Sorszam)
                    .ValueGeneratedNever()
                    .HasColumnName("SORSZAM");

                entity.Property(e => e.FizMod)
                    .HasMaxLength(255)
                    .HasColumnName("FIZ_MOD");

                entity.Property(e => e.Login)
                    .HasMaxLength(255)
                    .HasColumnName("LOGIN");

                entity.Property(e => e.RendDatum)
                    .HasColumnType("date")
                    .HasColumnName("REND_DATUM");

                entity.Property(e => e.SzallCim)
                    .HasMaxLength(255)
                    .HasColumnName("SZALL_CIM");

                entity.Property(e => e.SzallDatum)
                    .HasColumnType("date")
                    .HasColumnName("SZALL_DATUM");

                entity.Property(e => e.SzallMod)
                    .HasMaxLength(255)
                    .HasColumnName("SZALL_MOD");

                entity.Property(e => e.SzamlaCim)
                    .HasMaxLength(255)
                    .HasColumnName("SZAMLA_CIM");
            });

            modelBuilder.Entity<RendelesTetel>(entity =>
            {
                entity.HasKey(e => new { e.Sorszam, e.Termekkod });

                entity.ToTable("Rendeles_tetel");

                entity.Property(e => e.Sorszam).HasColumnName("SORSZAM");

                entity.Property(e => e.Termekkod)
                    .HasMaxLength(255)
                    .HasColumnName("TERMEKKOD");

                entity.Property(e => e.Egysegar).HasColumnName("EGYSEGAR");

                entity.Property(e => e.Mennyiseg).HasColumnName("MENNYISEG");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.RoomSk)
                    .HasName("PK__tmp_ms_x__328616CFC84C05C9");

                entity.ToTable("Room");

                entity.Property(e => e.RoomSk).HasColumnName("RoomSK");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Savok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Savok");

                entity.Property(e => e.Időpont).HasMaxLength(50);

                entity.Property(e => e.Sav).HasMaxLength(50);

                entity.Property(e => e.SavId).HasColumnName("Sav_id");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Statusok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("statusok");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AverageGrade).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Neptun)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Szallashely>(entity =>
            {
                entity.HasKey(e => e.SzallasId);

                entity.ToTable("Szallashely");

                entity.Property(e => e.SzallasId)
                    .ValueGeneratedNever()
                    .HasColumnName("SZALLAS_ID");

                entity.Property(e => e.Cim)
                    .HasMaxLength(100)
                    .HasColumnName("CIM");

                entity.Property(e => e.CsillagokSzama).HasColumnName("CSILLAGOK_SZAMA");

                entity.Property(e => e.Hely)
                    .HasMaxLength(20)
                    .HasColumnName("HELY");

                entity.Property(e => e.RogzIdo)
                    .HasColumnType("date")
                    .HasColumnName("ROGZ_IDO");

                entity.Property(e => e.Rogzitette)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ROGZITETTE");

                entity.Property(e => e.SzallasNev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SZALLAS_NEV");

                entity.Property(e => e.Tipus)
                    .HasMaxLength(50)
                    .HasColumnName("TIPUS");
            });

            modelBuilder.Entity<Szoba>(entity =>
            {
                entity.ToTable("Szoba");

                entity.Property(e => e.SzobaId)
                    .ValueGeneratedNever()
                    .HasColumnName("SZOBA_ID");

                entity.Property(e => e.Ferohely).HasColumnName("FEROHELY");

                entity.Property(e => e.Klimas)
                    .HasMaxLength(1)
                    .HasColumnName("KLIMAS");

                entity.Property(e => e.Potagy).HasColumnName("POTAGY");

                entity.Property(e => e.SzallasFk).HasColumnName("SZALLAS_FK");

                entity.Property(e => e.SzobaSzama)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("SZOBA_SZAMA");

                entity.HasOne(d => d.SzallasFkNavigation)
                    .WithMany(p => p.Szobas)
                    .HasForeignKey(d => d.SzallasFk)
                    .HasConstraintName("FK_Szoba_Szallashely");
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.HasKey(e => e.DayId)
                    .HasName("PK__Table__3214EC0723C5BC75");

                entity.ToTable("Table");

                entity.Property(e => e.DayId)
                    .ValueGeneratedNever()
                    .HasColumnName("DayID");
            });

            modelBuilder.Entity<TableName>(entity =>
            {
                entity.ToTable("TableName");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ColumnName2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ColumnName3)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tagok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tagok");

                entity.Property(e => e.Cim)
                    .HasMaxLength(255)
                    .HasColumnName("cim");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Kedvencnyelv).HasColumnName("kedvencnyelv");

                entity.Property(e => e.Kedvencstilus)
                    .HasMaxLength(50)
                    .HasColumnName("kedvencstilus");

                entity.Property(e => e.Nev)
                    .HasMaxLength(255)
                    .HasColumnName("nev");
            });

            modelBuilder.Entity<Tantárgyak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tantárgyak");

                entity.Property(e => e.Tantargykod).HasMaxLength(50);

                entity.Property(e => e.Tantárgynév).HasMaxLength(50);
            });

            modelBuilder.Entity<Termek>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Termek");

                entity.Property(e => e.Terem).HasMaxLength(50);
            });

            modelBuilder.Entity<Termekkategorium>(entity =>
            {
                entity.HasKey(e => e.KatId);

                entity.Property(e => e.KatId)
                    .ValueGeneratedNever()
                    .HasColumnName("KAT_ID");

                entity.Property(e => e.KatNev)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("KAT_NEV");

                entity.Property(e => e.SzuloKat).HasColumnName("SZULO_KAT");
            });

            modelBuilder.Entity<Termék>(entity =>
            {
                entity.HasKey(e => e.Termekkod);

                entity.ToTable("Termék");

                entity.Property(e => e.Termekkod)
                    .HasMaxLength(255)
                    .HasColumnName("TERMEKKOD");

                entity.Property(e => e.Felvitel)
                    .HasColumnType("date")
                    .HasColumnName("FELVITEL");

                entity.Property(e => e.Felvitte)
                    .HasMaxLength(255)
                    .HasColumnName("FELVITTE");

                entity.Property(e => e.KatId).HasColumnName("KAT_ID");

                entity.Property(e => e.Keszlet).HasColumnName("KESZLET");

                entity.Property(e => e.Leiras)
                    .HasMaxLength(255)
                    .HasColumnName("LEIRAS");

                entity.Property(e => e.Listaar).HasColumnName("LISTAAR");

                entity.Property(e => e.Megnevezes)
                    .HasMaxLength(255)
                    .HasColumnName("MEGNEVEZES");

                entity.Property(e => e.Megys)
                    .HasMaxLength(255)
                    .HasColumnName("MEGYS");

                entity.Property(e => e.RaktarKod).HasColumnName("RAKTAR_KOD");
            });

            modelBuilder.Entity<Termékkategorium>(entity =>
            {
                entity.HasKey(e => e.KatId);

                entity.Property(e => e.KatId)
                    .ValueGeneratedNever()
                    .HasColumnName("KAT_ID");

                entity.Property(e => e.KatNev)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("KAT_NEV");

                entity.Property(e => e.SzuloKat).HasColumnName("SZULO_KAT");
            });

            modelBuilder.Entity<Tesztfej>(entity =>
            {
                entity.HasKey(e => e.Kod)
                    .HasName("PK__tesztfej__DFD8EB9FD3164D8F");

                entity.ToTable("tesztfej");

                entity.Property(e => e.Kod)
                    .ValueGeneratedNever()
                    .HasColumnName("kod");

                entity.Property(e => e.Szoveg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("szoveg");
            });

            modelBuilder.Entity<Teszttetel>(entity =>
            {
                entity.HasKey(e => e.Kod)
                    .HasName("PK__teszttet__DFD8EB9F0D1B4293");

                entity.ToTable("teszttetel");

                entity.Property(e => e.Kod)
                    .ValueGeneratedNever()
                    .HasColumnName("kod");

                entity.Property(e => e.Fejkod).HasColumnName("fejkod");

                entity.HasOne(d => d.FejkodNavigation)
                    .WithMany(p => p.Teszttetels)
                    .HasForeignKey(d => d.Fejkod)
                    .HasConstraintName("FK__teszttete__fejko__7755B73D");
            });

            modelBuilder.Entity<Time>(entity =>
            {
                entity.ToTable("Time");

                entity.Property(e => e.TimeId)
                    .ValueGeneratedNever()
                    .HasColumnName("TimeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ugyfel>(entity =>
            {
                entity.HasKey(e => e.Login);

                entity.ToTable("Ugyfel");

                entity.Property(e => e.Login)
                    .HasMaxLength(255)
                    .HasColumnName("LOGIN");

                entity.Property(e => e.Cim)
                    .HasMaxLength(255)
                    .HasColumnName("CIM");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Nem)
                    .HasMaxLength(1)
                    .HasColumnName("NEM");

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("NEV");

                entity.Property(e => e.Szulev).HasColumnName("SZULEV");
            });

            modelBuilder.Entity<Vendeg>(entity =>
            {
                entity.HasKey(e => e.Usernev);

                entity.ToTable("Vendeg");

                entity.Property(e => e.Usernev)
                    .HasMaxLength(20)
                    .HasColumnName("USERNEV");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NEV");

                entity.Property(e => e.SzamlCim)
                    .HasMaxLength(100)
                    .HasColumnName("SZAML_CIM");

                entity.Property(e => e.SzulDat)
                    .HasColumnType("date")
                    .HasColumnName("SZUL_DAT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
