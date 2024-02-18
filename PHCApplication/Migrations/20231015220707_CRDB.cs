using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PHCApplication.Migrations
{
    public partial class CRDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Pharmacy");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "TestResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Procedures",
                table: "Procedures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "OrderVacc");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "OrderVacc");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Diagnose");

            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.RenameTable(
                name: "walk_In",
                newName: "walk_In",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Room",
                newName: "Room",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Reports",
                newName: "Reports",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Reminder",
                newName: "Reminder",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Referral",
                newName: "Referral",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "PrenatalApp",
                newName: "PrenatalApp",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Pharmacist",
                newName: "Pharmacist",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "OrderVacc",
                newName: "OrderVacc",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Medication",
                newName: "Medication",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "MedicalTest",
                newName: "MedicalTest",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "MedicalRecord",
                newName: "MedicalRecord",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Doctor",
                newName: "Doctor",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Discharge",
                newName: "Discharge",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Diagnose",
                newName: "Diagnose",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Detail",
                newName: "Detail",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Department",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Collection",
                newName: "Collection",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Bookings",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "AspNetUsers",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Appointment",
                newName: "Appointment",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "Admin",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Procedures",
                newName: "Procedure",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "UserTokens",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "UserRoles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "UserLogins",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "UserClaims",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Role",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "RoleClaims",
                newSchema: "Identity");

            migrationBuilder.RenameColumn(
                name: "deliveryDate",
                schema: "Identity",
                table: "OrderVacc",
                newName: "RequestDateTime");

            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "Identity",
                table: "Diagnose",
                newName: "DiagnoseId");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "Identity",
                table: "Procedure",
                newName: "ProcedureName");

            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "Identity",
                table: "Procedure",
                newName: "ProcedureId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "Identity",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "Identity",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "Identity",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "Identity",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.AddColumn<string>(
                name: "Room",
                schema: "Identity",
                table: "Discharge",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FollowUpAppointment",
                schema: "Identity",
                table: "Diagnose",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "MedicalFacility",
                schema: "Identity",
                table: "Diagnose",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MedicationDetails",
                schema: "Identity",
                table: "Diagnose",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                schema: "Identity",
                table: "Diagnose",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalDetails",
                schema: "Identity",
                table: "Bookings",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DurationInMinutes",
                schema: "Identity",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "TermsAndConditions",
                schema: "Identity",
                table: "Bookings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Equipment",
                schema: "Identity",
                table: "Procedure",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "RoomNumber",
                schema: "Identity",
                table: "Procedure",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "TermsAndConditions",
                schema: "Identity",
                table: "Procedure",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                schema: "Identity",
                table: "Procedure",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Procedure",
                schema: "Identity",
                table: "Procedure",
                column: "ProcedureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                schema: "Identity",
                table: "UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                schema: "Identity",
                table: "UserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                schema: "Identity",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                schema: "Identity",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                schema: "Identity",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Appoints",
                schema: "Identity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VaccinationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfVaccination = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appoints", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BookingApproval",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ApprovalComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingApproval", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatFeedback",
                schema: "Identity",
                columns: table => new
                {
                    ChatFeedbackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    WaitTimeInMinutes = table.Column<int>(type: "int", nullable: false),
                    TreatmentEffectiveness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommunicationClarity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EaseOfAppointment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SatisfactionWithExperience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommunicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CommunicationRating = table.Column<int>(type: "int", nullable: false),
                    ResponseTimeInMinutes = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatFeedback", x => x.ChatFeedbackId);
                    table.ForeignKey(
                        name: "FK_ChatFeedback_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollectionChronic",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CollectionDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionChronic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CollectionChronic_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CounsellingPrescroption",
                schema: "Identity",
                columns: table => new
                {
                    PrescroptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CounsellingPrescroption", x => x.PrescroptionId);
                    table.ForeignKey(
                        name: "FK_CounsellingPrescroption_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                schema: "Identity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Event = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Examination",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symptoms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagnose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Examination_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalHistory",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HistoryMentalHealthTreatment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentMentalHealthTreatment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Substance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalHistory_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalProcedureFile",
                schema: "Identity",
                columns: table => new
                {
                    MedicalProcedureFileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalProcedure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Part = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Symptoms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentMedications = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Allergies = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Treatment = table.Column<bool>(type: "bit", nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmokingHabit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlcoholConsumption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalProcedureFile", x => x.MedicalProcedureFileId);
                    table.ForeignKey(
                        name: "FK_MedicalProcedureFile_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patientss",
                schema: "Identity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostalAddress = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patientss", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Patientss_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferralsCounselling",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Medication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralsCounselling", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReferralsCounselling_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diagnose_UserID",
                schema: "Identity",
                table: "Diagnose",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Procedure_UserID",
                schema: "Identity",
                table: "Procedure",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ChatFeedback_UserID",
                schema: "Identity",
                table: "ChatFeedback",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionChronic_UserID",
                schema: "Identity",
                table: "CollectionChronic",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CounsellingPrescroption_UserID",
                schema: "Identity",
                table: "CounsellingPrescroption",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Examination_UserID",
                schema: "Identity",
                table: "Examination",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistory_UserID",
                schema: "Identity",
                table: "MedicalHistory",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalProcedureFile_UserID",
                schema: "Identity",
                table: "MedicalProcedureFile",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Patientss_UserID",
                schema: "Identity",
                table: "Patientss",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ReferralsCounselling_UserID",
                schema: "Identity",
                table: "ReferralsCounselling",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnose_AspNetUsers_UserID",
                schema: "Identity",
                table: "Diagnose",
                column: "UserID",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedure_AspNetUsers_UserID",
                schema: "Identity",
                table: "Procedure",
                column: "UserID",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Role_RoleId",
                schema: "Identity",
                table: "RoleClaims",
                column: "RoleId",
                principalSchema: "Identity",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_AspNetUsers_UserId",
                schema: "Identity",
                table: "UserClaims",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_AspNetUsers_UserId",
                schema: "Identity",
                table: "UserLogins",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_AspNetUsers_UserId",
                schema: "Identity",
                table: "UserRoles",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                schema: "Identity",
                table: "UserRoles",
                column: "RoleId",
                principalSchema: "Identity",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_AspNetUsers_UserId",
                schema: "Identity",
                table: "UserTokens",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnose_AspNetUsers_UserID",
                schema: "Identity",
                table: "Diagnose");

            migrationBuilder.DropForeignKey(
                name: "FK_Procedure_AspNetUsers_UserID",
                schema: "Identity",
                table: "Procedure");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Role_RoleId",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_AspNetUsers_UserId",
                schema: "Identity",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_AspNetUsers_UserId",
                schema: "Identity",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_AspNetUsers_UserId",
                schema: "Identity",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                schema: "Identity",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_AspNetUsers_UserId",
                schema: "Identity",
                table: "UserTokens");

            migrationBuilder.DropTable(
                name: "Appoints",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "BookingApproval",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "ChatFeedback",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "CollectionChronic",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "CounsellingPrescroption",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Events",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Examination",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "MedicalHistory",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "MedicalProcedureFile",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Patientss",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Ratings",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "ReferralsCounselling",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Identity");

            migrationBuilder.DropIndex(
                name: "IX_Diagnose_UserID",
                schema: "Identity",
                table: "Diagnose");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                schema: "Identity",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                schema: "Identity",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                schema: "Identity",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                schema: "Identity",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                schema: "Identity",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Procedure",
                schema: "Identity",
                table: "Procedure");

            migrationBuilder.DropIndex(
                name: "IX_Procedure_UserID",
                schema: "Identity",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "Room",
                schema: "Identity",
                table: "Discharge");

            migrationBuilder.DropColumn(
                name: "FollowUpAppointment",
                schema: "Identity",
                table: "Diagnose");

            migrationBuilder.DropColumn(
                name: "MedicalFacility",
                schema: "Identity",
                table: "Diagnose");

            migrationBuilder.DropColumn(
                name: "MedicationDetails",
                schema: "Identity",
                table: "Diagnose");

            migrationBuilder.DropColumn(
                name: "UserID",
                schema: "Identity",
                table: "Diagnose");

            migrationBuilder.DropColumn(
                name: "AdditionalDetails",
                schema: "Identity",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "DurationInMinutes",
                schema: "Identity",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "TermsAndConditions",
                schema: "Identity",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                schema: "Identity",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "TermsAndConditions",
                schema: "Identity",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "UserID",
                schema: "Identity",
                table: "Procedure");

            migrationBuilder.RenameTable(
                name: "walk_In",
                schema: "Identity",
                newName: "walk_In");

            migrationBuilder.RenameTable(
                name: "Room",
                schema: "Identity",
                newName: "Room");

            migrationBuilder.RenameTable(
                name: "Reports",
                schema: "Identity",
                newName: "Reports");

            migrationBuilder.RenameTable(
                name: "Reminder",
                schema: "Identity",
                newName: "Reminder");

            migrationBuilder.RenameTable(
                name: "Referral",
                schema: "Identity",
                newName: "Referral");

            migrationBuilder.RenameTable(
                name: "PrenatalApp",
                schema: "Identity",
                newName: "PrenatalApp");

            migrationBuilder.RenameTable(
                name: "Pharmacist",
                schema: "Identity",
                newName: "Pharmacist");

            migrationBuilder.RenameTable(
                name: "OrderVacc",
                schema: "Identity",
                newName: "OrderVacc");

            migrationBuilder.RenameTable(
                name: "Medication",
                schema: "Identity",
                newName: "Medication");

            migrationBuilder.RenameTable(
                name: "MedicalTest",
                schema: "Identity",
                newName: "MedicalTest");

            migrationBuilder.RenameTable(
                name: "MedicalRecord",
                schema: "Identity",
                newName: "MedicalRecord");

            migrationBuilder.RenameTable(
                name: "Doctor",
                schema: "Identity",
                newName: "Doctor");

            migrationBuilder.RenameTable(
                name: "Discharge",
                schema: "Identity",
                newName: "Discharge");

            migrationBuilder.RenameTable(
                name: "Diagnose",
                schema: "Identity",
                newName: "Diagnose");

            migrationBuilder.RenameTable(
                name: "Detail",
                schema: "Identity",
                newName: "Detail");

            migrationBuilder.RenameTable(
                name: "Department",
                schema: "Identity",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Collection",
                schema: "Identity",
                newName: "Collection");

            migrationBuilder.RenameTable(
                name: "Bookings",
                schema: "Identity",
                newName: "Bookings");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "Identity",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Appointment",
                schema: "Identity",
                newName: "Appointment");

            migrationBuilder.RenameTable(
                name: "Admin",
                schema: "Identity",
                newName: "Admin");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "Identity",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "Identity",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "Identity",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "Identity",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "Identity",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "Identity",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "Procedure",
                schema: "Identity",
                newName: "Procedures");

            migrationBuilder.RenameColumn(
                name: "RequestDateTime",
                table: "OrderVacc",
                newName: "deliveryDate");

            migrationBuilder.RenameColumn(
                name: "DiagnoseId",
                table: "Diagnose",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.RenameColumn(
                name: "ProcedureName",
                table: "Procedures",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProcedureId",
                table: "Procedures",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "OrderVacc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "OrderVacc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Diagnose",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Equipment",
                table: "Procedures",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Procedures",
                table: "Procedures",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastMaintenanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    MedicalHistory = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostalAddress = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OperatingHours = table.Column<int>(type: "int", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestResult", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
