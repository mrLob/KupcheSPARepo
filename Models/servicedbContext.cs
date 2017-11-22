using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KupcheAspNetCore
{
    public partial class servicedbContext : DbContext
    {
        public virtual DbSet<Activitytypes> Activitytypes { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<Companyactivity> Companyactivity { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Nomenclatures> Nomenclatures { get; set; }
        public virtual DbSet<Orderfiles> Orderfiles { get; set; }
        public virtual DbSet<Orderimages> Orderimages { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Pricelist> Pricelist { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Roomusers> Roomusers { get; set; }
        public virtual DbSet<Rules> Rules { get; set; }
        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<Signinup> Signinup { get; set; }
        public virtual DbSet<Subcategory> Subcategory { get; set; }
        public virtual DbSet<Supercategories> Supercategories { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                 optionsBuilder.UseMySql("User Id=root ;password=root;Host=127.0.0.1;Database=servicedb;");
//             }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activitytypes>(entity =>
            {
                entity.HasKey(e => e.IdActivityTypes);

                entity.ToTable("activitytypes", "servicedb");

                entity.Property(e => e.IdActivityTypes).HasColumnName("idActivityTypes");

                entity.Property(e => e.ActivityTypesName)
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ChildOf).HasColumnName("Child_Of");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Activitytypes)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("fk_ActivityTypes_Category");

                entity.HasOne(d => d.ChildOfNavigation)
                    .WithMany(p => p.InverseChildOfNavigation)
                    .HasForeignKey(d => d.ChildOf)
                    .HasConstraintName("fk_ActivityTypes_Child");
            });

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.IdAddress);

                entity.ToTable("addresses", "servicedb");

                entity.Property(e => e.IdAddress).HasColumnName("idAddress");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.AddressFlat)
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.Property(e => e.AddressStreet)
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.Property(e => e.AddressZip)
                    .HasColumnName("AddressZIP")
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.Property(e => e.AddressesGeomap)
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Address_City");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.IdCity);

                entity.ToTable("city", "servicedb");

                entity.Property(e => e.IdCity).HasColumnName("idCity");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_City_Country");
            });

            modelBuilder.Entity<Companies>(entity =>
            {
                entity.HasKey(e => e.IdCompany);

                entity.ToTable("companies", "servicedb");

                entity.Property(e => e.IdCompany).HasColumnName("idCompany");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CompaniesAbout).HasColumnType("mediumtext");

                entity.Property(e => e.CompanyContacts)
                    .IsRequired()
                    .HasColumnType("tinytext");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(200);

                entity.Property(e => e.CompanyPan)
                    .IsRequired()
                    .HasColumnName("CompanyPAN")
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.Property(e => e.CompanyShortName)
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Company_Addresses");
            });

            modelBuilder.Entity<Companyactivity>(entity =>
            {
                entity.HasKey(e => e.IdCompanyActivity);

                entity.ToTable("companyactivity", "servicedb");

                entity.Property(e => e.IdCompanyActivity).HasColumnName("idCompanyActivity");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.Companyactivity)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CompanyActivity_1");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Companyactivity)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CompanyActivity_2");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.IdCountry);

                entity.ToTable("country", "servicedb");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(145);

                entity.Property(e => e.CountryShortName)
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Currencies>(entity =>
            {
                entity.HasKey(e => e.IdCurrencies);

                entity.ToTable("currencies", "servicedb");

                entity.Property(e => e.IdCurrencies).HasColumnName("idCurrencies");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(145);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Files>(entity =>
            {
                entity.HasKey(e => e.IdFiles);

                entity.ToTable("files", "servicedb");

                entity.Property(e => e.IdFiles).HasColumnName("idFiles");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Files_Users");
            });

            modelBuilder.Entity<Goods>(entity =>
            {
                entity.HasKey(e => e.IdGoods);

                entity.ToTable("goods", "servicedb");

                entity.Property(e => e.IdGoods).HasColumnName("idGoods");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.GoodsCost)
                    .HasDefaultValueSql("0.00")
                    .HasAnnotation("Precision", 6)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.GoodsParams).HasColumnType("mediumtext");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.Nomenclatures)
                    .WithMany(p => p.Goods)
                    .HasForeignKey(d => d.NomenclaturesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Goods_1");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.Goods)
                    .HasForeignKey(d => d.SubcategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Goods_Subcategory");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Goods)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("fk_Goods_Measure");
            });

            modelBuilder.Entity<Images>(entity =>
            {
                entity.HasKey(e => e.IdImages);

                entity.ToTable("images", "servicedb");

                entity.Property(e => e.IdImages).HasColumnName("idImages");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_Images_Users");
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasKey(e => e.MsgId);

                entity.ToTable("messages", "servicedb");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsViewed)
                    .HasColumnName("is_viewed")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MessageText)
                    .IsRequired()
                    .HasColumnType("mediumtext");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Messages_Room");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Messages_Users");
            });

            modelBuilder.Entity<Nomenclatures>(entity =>
            {
                entity.HasKey(e => e.IdNomenclatures);

                entity.ToTable("nomenclatures", "servicedb");

                entity.Property(e => e.IdNomenclatures).HasColumnName("idNomenclatures");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NomenclaturesName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(450);
            });

            modelBuilder.Entity<Orderfiles>(entity =>
            {
                entity.HasKey(e => e.IdOrderFiles);

                entity.ToTable("orderfiles", "servicedb");

                entity.Property(e => e.IdOrderFiles).HasColumnName("idOrderFiles");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.Orderfiles)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OrderFiles_Files");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Orderfiles)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OrderFiles_Orders");
            });

            modelBuilder.Entity<Orderimages>(entity =>
            {
                entity.HasKey(e => e.IdOrderImages);

                entity.ToTable("orderimages", "servicedb");

                entity.Property(e => e.IdOrderImages).HasColumnName("idOrderImages");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Orderimages)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OrderImages_Images");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Orderimages)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OrderImages_Orders");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.IdOrders);

                entity.ToTable("orders", "servicedb");

                entity.Property(e => e.IdOrders).HasColumnName("idOrders");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

                entity.Property(e => e.Cost)
                    .HasDefaultValueSql("0.00")
                    .HasAnnotation("Precision", 6)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.Geomap)
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("mediumtext");

                entity.Property(e => e.ThereFiles)
                    .HasColumnName("there_files")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ThereImages)
                    .HasColumnName("there_images")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Viewers).HasDefaultValueSql("0");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Orders_1");
            });

            modelBuilder.Entity<Positions>(entity =>
            {
                entity.HasKey(e => e.IdPositions);

                entity.ToTable("positions", "servicedb");

                entity.Property(e => e.IdPositions).HasColumnName("idPositions");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PositionsName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(145);

                entity.Property(e => e.ShortName)
                    .HasColumnType("varchar")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Pricelist>(entity =>
            {
                entity.HasKey(e => e.IdPricelist);

                entity.ToTable("pricelist", "servicedb");

                entity.Property(e => e.IdPricelist).HasColumnName("idPricelist");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.PricelistCount).HasDefaultValueSql("0");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Pricelist)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Pricelist_Company");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Pricelist)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Pricelist_Currency");

                entity.HasOne(d => d.Goods)
                    .WithMany(p => p.Pricelist)
                    .HasForeignKey(d => d.GoodsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Pricelist_Goods");
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.HasKey(e => e.IdRooms);

                entity.ToTable("rooms", "servicedb");

                entity.Property(e => e.IdRooms).HasColumnName("idRooms");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsCompanyRoom)
                    .HasColumnName("is_CompanyRoom")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.RoomsName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

                entity.HasOne(d => d.RoomsCreator)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.RoomsCreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Rooms_Users");
            });

            modelBuilder.Entity<Roomusers>(entity =>
            {
                entity.HasKey(e => e.IdRoomUsers);

                entity.ToTable("roomusers", "servicedb");

                entity.Property(e => e.IdRoomUsers).HasColumnName("idRoomUsers");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Roomusers)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_RoomUsers_Rooms");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Roomusers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_RoomUsers_Users");
            });

            modelBuilder.Entity<Rules>(entity =>
            {
                entity.HasKey(e => e.IdRules);

                entity.ToTable("rules", "servicedb");

                entity.Property(e => e.IdRules).HasColumnName("idRules");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Sessions>(entity =>
            {
                entity.HasKey(e => e.IdSessions);

                entity.ToTable("sessions", "servicedb");

                entity.Property(e => e.IdSessions).HasColumnName("idSessions");

                entity.Property(e => e.BeginTime).HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SessionIp)
                    .HasColumnName("SessionIP")
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Sessions_Users");
            });

            modelBuilder.Entity<Signinup>(entity =>
            {
                entity.HasKey(e => e.IdSignInUp);

                entity.ToTable("signinup", "servicedb");

                entity.Property(e => e.IdSignInUp).HasColumnName("idSignInUp");

                entity.Property(e => e.ActivatedIn).HasColumnName("activated_in");

                entity.Property(e => e.ExpiredIn)
                    .HasColumnName("expired_in")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsActivated)
                    .HasColumnName("is_activated")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(45);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(55);
            });

            modelBuilder.Entity<Subcategory>(entity =>
            {
                entity.HasKey(e => e.IdSubcategory);

                entity.ToTable("subcategory", "servicedb");

                entity.Property(e => e.IdSubcategory).HasColumnName("idSubcategory");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsCategory)
                    .HasColumnName("is_Category")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.OfChild).HasColumnName("of_Child");

                entity.Property(e => e.SubcategoryInfo).HasColumnType("text");

                entity.Property(e => e.SubcategoryName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Subcategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Subcategory_Catrgory");

                entity.HasOne(d => d.OfChildNavigation)
                    .WithMany(p => p.InverseOfChildNavigation)
                    .HasForeignKey(d => d.OfChild)
                    .HasConstraintName("fk_Subcategory_Child");
            });

            modelBuilder.Entity<Supercategories>(entity =>
            {
                entity.HasKey(e => e.IdSuperCategories);

                entity.ToTable("supercategories", "servicedb");

                entity.Property(e => e.IdSuperCategories).HasColumnName("idSuperCategories");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SuperCategoriesName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Units>(entity =>
            {
                entity.HasKey(e => e.IdUnit);

                entity.ToTable("units", "servicedb");

                entity.Property(e => e.IdUnit).HasColumnName("idUnit");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(145);

                entity.Property(e => e.UnitsShortName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.IdUsers);

                entity.ToTable("users", "servicedb");

                entity.Property(e => e.IdUsers).HasColumnName("idUsers");

                entity.Property(e => e.AdditionTime)
                    .HasColumnName("addition_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.BlockedTime)
                    .HasColumnName("blocked_time")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(200);

                entity.Property(e => e.IsBlocked)
                    .HasColumnName("is_blocked")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(200);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.SecondName)
                    .HasColumnType("varchar")
                    .HasMaxLength(200);

                entity.Property(e => e.Telephone)
                    .HasColumnType("varchar")
                    .HasMaxLength(11);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Users_Company");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Users_Positions");

                entity.HasOne(d => d.Rules)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RulesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Users_Rules");
            });
        }
    }
}
