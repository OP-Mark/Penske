using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Penske.Mobilep.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Control",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Safety = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    Inspection = table.Column<int>(nullable: true),
                    Entry = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Control", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ForkliftGoal",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Goal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForkliftGoal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ForkliftUtilization",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<int>(nullable: true),
                    Yyear = table.Column<int>(nullable: true),
                    Mmonth = table.Column<int>(nullable: true),
                    Wweek = table.Column<int>(nullable: true),
                    Hhours = table.Column<int>(nullable: true),
                    Ppercent = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForkliftUtilization", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Inspection",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Control = table.Column<string>(maxLength: 20, nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    Unit = table.Column<string>(maxLength: 10, nullable: true),
                    OperatorId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    StartTime = table.Column<string>(maxLength: 10, nullable: true),
                    Type = table.Column<string>(maxLength: 5, nullable: true),
                    EndMeter = table.Column<string>(maxLength: 10, nullable: true),
                    TimeEndMeter = table.Column<string>(maxLength: 10, nullable: true),
                    StartMeter = table.Column<string>(maxLength: 10, nullable: true),
                    TimeStartMeter = table.Column<string>(maxLength: 10, nullable: true),
                    TireWheels = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Lights = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Gauges = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    SeatBelt = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Decals = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    TransOil = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    OverheadGard = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    EngineOil = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    HydraulicFluid = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    RadiatorFluid = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    EngineHoses = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Steering = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Brakes = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    HandBrake = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Horn = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Battery = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ShiftLevels = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Fork = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Leaks = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    BackupAlarm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    FireExtinguisher = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    AirFilter = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    Comments = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Control = table.Column<string>(maxLength: 20, nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    OperatorId = table.Column<int>(nullable: true),
                    Location = table.Column<string>(maxLength: 10, nullable: true),
                    VIN = table.Column<string>(maxLength: 25, nullable: true),
                    Model = table.Column<string>(maxLength: 20, nullable: true),
                    Status = table.Column<int>(nullable: true),
                    CYC = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "InventoryStatus",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStatus = table.Column<string>(maxLength: 20, nullable: false),
                    Active = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LocationsConfiguration",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NVins = table.Column<int>(nullable: false),
                    Location = table.Column<string>(maxLength: 10, nullable: true),
                    Models = table.Column<string>(maxLength: 250, nullable: true),
                    ModelsPriorityI = table.Column<string>(maxLength: 250, nullable: true),
                    ModelsPriorityR = table.Column<string>(maxLength: 250, nullable: true),
                    Authorize = table.Column<bool>(nullable: true),
                    Scanning = table.Column<bool>(nullable: true),
                    Rrow = table.Column<string>(maxLength: 10, nullable: true),
                    Ccolumn = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationsConfiguration", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LogBitacora",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    Control = table.Column<string>(maxLength: 20, nullable: true),
                    VIN = table.Column<string>(maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogBitacora", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MODEL = table.Column<string>(maxLength: 15, nullable: true),
                    Comments = table.Column<string>(maxLength: 250, nullable: true),
                    IsComments = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Safety",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Control = table.Column<string>(maxLength: 20, nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: true),
                    OperatorId = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    StartTime = table.Column<string>(maxLength: 10, nullable: true),
                    EndTime = table.Column<string>(maxLength: 10, nullable: true),
                    DockNum = table.Column<string>(maxLength: 4, nullable: true),
                    WeelChocked = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    TrailerLock = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    CurtainFullyOpen = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Carrier = table.Column<string>(maxLength: 50, nullable: true),
                    Trailer = table.Column<string>(maxLength: 10, nullable: true),
                    LoadType = table.Column<string>(maxLength: 10, nullable: true),
                    LoadID = table.Column<string>(maxLength: 10, nullable: true),
                    QtyUnits = table.Column<int>(nullable: true),
                    QtyDamage = table.Column<int>(nullable: true),
                    QtyNoLabel = table.Column<int>(nullable: true),
                    TandemLocking = table.Column<bool>(nullable: true),
                    TrlInspected = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Safety", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(fixedLength: true, maxLength: 80, nullable: true),
                    Password = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
                    FullName = table.Column<string>(fixedLength: true, maxLength: 50, nullable: true),
                    Perfil = table.Column<int>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VirtualLocationConfiguration",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NRowLocation = table.Column<int>(nullable: false),
                    NColumnLocation = table.Column<int>(nullable: false),
                    NAisles = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirtualLocationConfiguration", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Control");

            migrationBuilder.DropTable(
                name: "ForkliftGoal");

            migrationBuilder.DropTable(
                name: "ForkliftUtilization");

            migrationBuilder.DropTable(
                name: "Inspection");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "InventoryStatus");

            migrationBuilder.DropTable(
                name: "LocationsConfiguration");

            migrationBuilder.DropTable(
                name: "LogBitacora");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Safety");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VirtualLocationConfiguration");
        }
    }
}
