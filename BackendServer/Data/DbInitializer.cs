using BackendServer.Data.EF;
using BackendServer.Data.Enums;
using BaoHiemPhiNhanTho.BackendServer.Models;

namespace BackendServer.Data;

public class DbInitializer
{
    private readonly BHPNTDbContext _context;

    public DbInitializer(BHPNTDbContext context)
    {
        _context = context;
    }

    public async Task Seed()
    {
        if (!_context.Partners.Any())
        {
            _context.Partners.AddRange(new List<Partner>()
            {
                new Partner(){PartnerCode = "001", Name = "ABC"},
                new Partner(){PartnerCode = "002", Name = "DEF"},
                new Partner(){PartnerCode = "003", Name = "XYZ"},
                new Partner(){PartnerCode = "004", Name = "MNO"},
                new Partner(){PartnerCode = "005", Name = "QPR"},
                new Partner(){PartnerCode = "006", Name = "STU"},
                new Partner(){PartnerCode = "007", Name = "VWX"},
                new Partner(){PartnerCode = "008", Name = "GHI"},
                new Partner(){PartnerCode = "009", Name = "JKL"},
                new Partner(){PartnerCode = "010", Name = "NOP"},
                new Partner(){PartnerCode = "011", Name = "QRS"},
                new Partner(){PartnerCode = "012", Name = "TUV"},
                new Partner(){PartnerCode = "013", Name = "WXY"},
                new Partner(){PartnerCode = "014", Name = "ZAB"},
                new Partner(){PartnerCode = "015", Name = "CDE"},
                new Partner(){PartnerCode = "016", Name = "FGH"},
                new Partner(){PartnerCode = "017", Name = "IJK"},
                new Partner(){PartnerCode = "018", Name = "LMN"},
                new Partner(){PartnerCode = "019", Name = "OPQ"},
                new Partner(){PartnerCode = "020", Name = "RST"},
                new Partner(){PartnerCode = "021", Name = "UVW"},
                new Partner(){PartnerCode = "022", Name = "XYZ"},
                new Partner(){PartnerCode = "023", Name = "ABC"},
                new Partner(){PartnerCode = "024", Name = "DEF"},
                new Partner(){PartnerCode = "025", Name = "GHI"},
            });
            await _context.SaveChangesAsync();
        }

        if (!_context.Branches.Any())
        {
            _context.Branches.AddRange(new List<Branch>()
            {
                new Branch(){BranchCode = "001", BranchName = "CN Tân Bình"},
                new Branch(){BranchCode = "002", BranchName = "CN Gò Vấp"},
                new Branch(){BranchCode = "003", BranchName = "CN Bình Thạnh"},
                new Branch(){BranchCode = "004", BranchName = "CN Quận 1"},
                new Branch(){BranchCode = "005", BranchName = "CN Quận 2"},
                new Branch(){BranchCode = "006", BranchName = "CN Quận 3"},
                new Branch(){BranchCode = "007", BranchName = "CN Quận 4"},
                new Branch(){BranchCode = "008", BranchName = "CN Quận 5"},
                new Branch(){BranchCode = "009", BranchName = "CN Quận 6"},
                new Branch(){BranchCode = "010", BranchName = "CN Quận 7"},
                new Branch(){BranchCode = "011", BranchName = "CN Quận 8"},
                new Branch(){BranchCode = "012", BranchName = "CN Quận 9"},
                new Branch(){BranchCode = "013", BranchName = "CN Quận 10"},
                new Branch(){BranchCode = "014", BranchName = "CN Quận 11"},
                new Branch(){BranchCode = "015", BranchName = "CN Quận 12"},
                new Branch(){BranchCode = "016", BranchName = "CN Bình Tân"},
                new Branch(){BranchCode = "017", BranchName = "CN Thủ Đức"},
                new Branch(){BranchCode = "018", BranchName = "CN Tân Phú"},
                new Branch(){BranchCode = "019", BranchName = "CN Phú Nhuận"},
                new Branch(){BranchCode = "020", BranchName = "CN Bình Chánh"},
            });
            await _context.SaveChangesAsync();
        }

        if (!_context.InfoCBNVs.Any())
        {
            _context.InfoCBNVs.AddRange(new List<InfoCBNV>()
            {
                new InfoCBNV(){TVTTCode = "001", NameTVTT = "Nguyễn Văn Huy", InfoCBNVBranchCode="001", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "002", NameTVTT = "Nguyễn Phú Đức", InfoCBNVBranchCode="001", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "003", NameTVTT = "Đỗ Phát Đạt", InfoCBNVBranchCode="002", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "004", NameTVTT = "Ngô Trí Trường", InfoCBNVBranchCode="002", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "005", NameTVTT = "Hoàng Bảo Phúc", InfoCBNVBranchCode="003", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "006", NameTVTT = "Nguyễn Văn Huy", InfoCBNVBranchCode="003", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "007", NameTVTT = "Nguyễn Phú Đức", InfoCBNVBranchCode="004", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "008", NameTVTT = "Đỗ Phát Đạt", InfoCBNVBranchCode="004", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "009", NameTVTT = "Ngô Trí Trường", InfoCBNVBranchCode="005", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "010", NameTVTT = "Hoàng Bảo Phúc", InfoCBNVBranchCode="005", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "011", NameTVTT = "Nguyễn Văn Huy", InfoCBNVBranchCode="006", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "012", NameTVTT = "Nguyễn Phú Đức", InfoCBNVBranchCode="006", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "013", NameTVTT = "Đỗ Phát Đạt", InfoCBNVBranchCode="007", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "014", NameTVTT = "Ngô Trí Trường", InfoCBNVBranchCode="007", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "015", NameTVTT = "Hoàng Bảo Phúc", InfoCBNVBranchCode="008", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "016", NameTVTT = "Nguyễn Văn Huy", InfoCBNVBranchCode="008", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "017", NameTVTT = "Nguyễn Phú Đức", InfoCBNVBranchCode="009", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "018", NameTVTT = "Đỗ Phát Đạt", InfoCBNVBranchCode="009", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "019", NameTVTT = "Ngô Trí Trường", InfoCBNVBranchCode="010", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
                new InfoCBNV(){TVTTCode = "020", NameTVTT = "Hoàng Bảo Phúc", InfoCBNVBranchCode="010", Branch = _context.Branches.FirstOrDefault(b => b.BranchCode == "001")},
            });
            await _context.SaveChangesAsync();
        }

        var customer1 = new Customer() { Cif = "987654321", Name = "Customer1", CustomerType = CustomerType.KHDN, Gender = "Nam", CCCD = "125087654321" };

        if (!_context.Customers.Any())
        {
            _context.Customers.AddRange(new List<Customer>()
            {
                new Customer(){Cif = "987654321", Name = "Customer1", CustomerType=CustomerType.KHDN, Gender = "Nam", CCCD="125087654321"},
                new Customer(){Cif = "987654322", Name = "Customer2", CustomerType=CustomerType.KHDN, Gender = "Nam", CCCD="125087654322"},
                new Customer(){Cif = "987654323", Name = "Customer3", CustomerType=CustomerType.KHCN, Gender = "Nam", CCCD="125087654323"},
                new Customer(){Cif = "987654324", Name = "Customer4", CustomerType=CustomerType.KHCN, Gender = "Nam", CCCD="125087654324"},
                new Customer(){Cif = "987654325", Name = "Customer5", CustomerType=CustomerType.KHCN, Gender = "Nam", CCCD="125087654325"},
                new Customer(){Cif = "987654326", Name = "Customer6", CustomerType=CustomerType.KHCN, Gender = "Nam", CCCD="125087654326"},
            });
            await _context.SaveChangesAsync();
        }

        if (!_context.Collaterals.Any())
        {
            _context.Collaterals.AddRange(new List<Collateral>()
            {
                new Collateral(){Ref = "987654321", StatusCollateral = "Active", ValueCollateral=100000000, AddressCollateral = "ABC", Relationship=Relationship.Relationship1, PropertyType="Nhà phố"},
                new Collateral(){Ref = "987654322", StatusCollateral = "Active", ValueCollateral=100000000, AddressCollateral = "DEF", Relationship=Relationship.Relationship2, PropertyType="Xe"},
                new Collateral(){Ref = "987654323", StatusCollateral = "Blank", ValueCollateral=100000000, AddressCollateral = "DEF2", Relationship=Relationship.Relationship2, PropertyType="Xe"},
                new Collateral(){Ref = "987654324", StatusCollateral = "Active", ValueCollateral=100000000, AddressCollateral = "DEF3", Relationship=Relationship.Relationship2, PropertyType="Xe"},
                new Collateral(){Ref = "987654325", StatusCollateral = "Blank", ValueCollateral=100000000, AddressCollateral = "ABC2", Relationship=Relationship.Relationship2, PropertyType="Nhà phố"},
                new Collateral(){Ref = "987654326", StatusCollateral = "Active", ValueCollateral=100000000, AddressCollateral = "ABC3", Relationship=Relationship.Relationship2, PropertyType="Nhà phố"},
            });
            await _context.SaveChangesAsync();
        }

        if (!_context.InsuranceContracts.Any())
        {
            _context.InsuranceContracts.AddRange(new List<InsuranceContract>()
            {
                new InsuranceContract(){HDBH = "987654321",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee = 1000000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Beneficiaries="Blank",
                InsuranceType= InsuranceType.InsuranceType1,
                OtherInsuranceType= "Khác",
                InsuranceBeneficiary= InsuranceBeneficiary.InsuranceType1,
                Cif = "987654321",
                TVTTCode = "001",
                InsurancePartnerCode="001",
                CollateralRef = "987654321",
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Partner = _context.Partners.FirstOrDefault(b => b.PartnerCode == "001"),
                Collateral = _context.Collaterals.FirstOrDefault(b => b.Ref == "987654321"),
                },

                new InsuranceContract(){HDBH = "987654322",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee = 1000000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Beneficiaries="Blank",
                InsuranceType= InsuranceType.InsuranceType1,
                OtherInsuranceType= "Khác",
                InsuranceBeneficiary= InsuranceBeneficiary.InsuranceType1,
                Cif = "987654321",
                TVTTCode = "001",
                InsurancePartnerCode="001",
                CollateralRef = "987654321",
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Partner = _context.Partners.FirstOrDefault(b => b.PartnerCode == "001"),
                Collateral = _context.Collaterals.FirstOrDefault(b => b.Ref == "987654321"),
                },

                new InsuranceContract(){HDBH = "987654323",
                NewOrRenewed = false,
                STBH=100000000,
                InsuranceFee = 1000000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Beneficiaries="Blank",
                InsuranceType= InsuranceType.InsuranceType1,
                OtherInsuranceType= "Khác",
                InsuranceBeneficiary= InsuranceBeneficiary.InsuranceType1,
                Cif = "987654321",
                TVTTCode = "001",
                InsurancePartnerCode="001",
                CollateralRef = "987654321",
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Partner = _context.Partners.FirstOrDefault(b => b.PartnerCode == "001"),
                Collateral = _context.Collaterals.FirstOrDefault(b => b.Ref == "987654321"),
                },

                new InsuranceContract(){HDBH = "987654324",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee = 1000000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Beneficiaries="Blank",
                InsuranceType= InsuranceType.InsuranceType1,
                OtherInsuranceType= "Khác",
                InsuranceBeneficiary= InsuranceBeneficiary.InsuranceType1,
                Cif = "987654321",
                TVTTCode = "001",
                InsurancePartnerCode="001",
                CollateralRef = "987654321",
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Partner = _context.Partners.FirstOrDefault(b => b.PartnerCode == "001"),
                Collateral = _context.Collaterals.FirstOrDefault(b => b.Ref == "987654321"),
                },

                new InsuranceContract(){HDBH = "987654325",
                NewOrRenewed = false,
                STBH=100000000,
                InsuranceFee = 1000000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Beneficiaries="Blank",
                InsuranceType= InsuranceType.InsuranceType1,
                OtherInsuranceType= "Khác",
                InsuranceBeneficiary= InsuranceBeneficiary.InsuranceType1,
                Cif = "987654321",
                TVTTCode = "001",
                InsurancePartnerCode="001",
                CollateralRef = "987654321",
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Partner = _context.Partners.FirstOrDefault(b => b.PartnerCode == "001"),
                Collateral = _context.Collaterals.FirstOrDefault(b => b.Ref == "987654321"),
                },

                new InsuranceContract(){HDBH = "987654326",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee = 1000000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Beneficiaries="Blank",
                InsuranceType= InsuranceType.InsuranceType1,
                OtherInsuranceType= "Khác",
                InsuranceBeneficiary= InsuranceBeneficiary.InsuranceType1,
                Cif = "987654321",
                TVTTCode = "001",
                InsurancePartnerCode="001",
                CollateralRef = "987654321",
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Partner = _context.Partners.FirstOrDefault(b => b.PartnerCode == "001"),
                Collateral = _context.Collaterals.FirstOrDefault(b => b.Ref == "987654321"),
                },

                new InsuranceContract(){HDBH = "987654327",
                NewOrRenewed = false,
                STBH=100000000,
                InsuranceFee = 1000000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Beneficiaries="Blank",
                InsuranceType= InsuranceType.InsuranceType1,
                OtherInsuranceType= "Khác",
                InsuranceBeneficiary= InsuranceBeneficiary.InsuranceType1,
                Cif = "987654321",
                TVTTCode = "001",
                InsurancePartnerCode="001",
                CollateralRef = "987654321",
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Partner = _context.Partners.FirstOrDefault(b => b.PartnerCode == "001"),
                Collateral = _context.Collaterals.FirstOrDefault(b => b.Ref == "987654321"),
                },

                new InsuranceContract(){HDBH = "987654328",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee = 1000000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Beneficiaries="Blank",
                InsuranceType= InsuranceType.InsuranceType1,
                OtherInsuranceType= "Khác",
                InsuranceBeneficiary= InsuranceBeneficiary.InsuranceType1,
                Cif = "987654321",
                TVTTCode = "001",
                InsurancePartnerCode="001",
                CollateralRef = "987654321",
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Partner = _context.Partners.FirstOrDefault(b => b.PartnerCode == "001"),
                Collateral = _context.Collaterals.FirstOrDefault(b => b.Ref == "987654321"),
                },

                new InsuranceContract(){HDBH = "987654329",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee = 1000000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Beneficiaries="Blank",
                InsuranceType= InsuranceType.InsuranceType1,
                OtherInsuranceType= "Khác",
                InsuranceBeneficiary= InsuranceBeneficiary.InsuranceType1,
                Cif = "987654321",
                TVTTCode = "001",
                InsurancePartnerCode="001",
                CollateralRef = "987654321",
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Partner = _context.Partners.FirstOrDefault(b => b.PartnerCode == "001"),
                Collateral = _context.Collaterals.FirstOrDefault(b => b.Ref == "987654321"),
                },

                new InsuranceContract(){HDBH = "987654330",
                NewOrRenewed = false,
                STBH=100000000,
                InsuranceFee = 1000000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Beneficiaries="Blank",
                InsuranceType= InsuranceType.InsuranceType1,
                OtherInsuranceType= "Khác",
                InsuranceBeneficiary= InsuranceBeneficiary.InsuranceType1,
                Cif = "987654321",
                TVTTCode = "001",
                InsurancePartnerCode="001",
                CollateralRef = "987654321",
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Partner = _context.Partners.FirstOrDefault(b => b.PartnerCode == "001"),
                Collateral = _context.Collaterals.FirstOrDefault(b => b.Ref == "987654321"),
                },

                new InsuranceContract(){HDBH = "987654331",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee = 1000000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Beneficiaries="Blank",
                InsuranceType= InsuranceType.InsuranceType1,
                OtherInsuranceType= "Khác",
                InsuranceBeneficiary= InsuranceBeneficiary.InsuranceType1,
                Cif = "987654321",
                TVTTCode = "001",
                InsurancePartnerCode="001",
                CollateralRef = "987654321",
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Partner = _context.Partners.FirstOrDefault(b => b.PartnerCode == "001"),
                Collateral = _context.Collaterals.FirstOrDefault(b => b.Ref == "987654321"),
                },
            });
            await _context.SaveChangesAsync();
        }

        if (!_context.AnnexContracts.Any())
        {
            _context.AnnexContracts.AddRange(new List<AnnexContract>()
            {
                new AnnexContract(){HDPL = "987654321",
                NewOrRenewed = true, STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },

                new AnnexContract(){HDPL = "987654322",
                NewOrRenewed = true, STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },

                new AnnexContract(){HDPL = "987654323",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },

                new AnnexContract(){HDPL = "987654324",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },

                new AnnexContract(){HDPL = "987654325",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },

                new AnnexContract(){HDPL = "987654326",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },

                new AnnexContract(){HDPL = "987654327",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },

                new AnnexContract(){HDPL = "987654328",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },

                new AnnexContract(){HDPL = "987654329",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },

                new AnnexContract(){HDPL = "987654330",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },

                new AnnexContract(){HDPL = "987654331",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },

                new AnnexContract(){HDPL = "987654332",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },

                new AnnexContract(){HDPL = "987654333",
                NewOrRenewed = true,
                STBH=100000000,
                InsuranceFee=100000000,
                NumberOfPayments=1,
                FromDate=DateTime.UtcNow.AddDays(-100),
                ToDate=DateTime.UtcNow.AddDays(-10),
                Exception = "",
                Cif = "987654321",
                HDBH = "987654321",
                TVTTCode = "001",
                Status = "chưa chuyển duyệt",
                InsuranceContract = _context.InsuranceContracts.FirstOrDefault(b => b.HDBH == "987654321"),
                InfoCBNV = _context.InfoCBNVs.FirstOrDefault(b => b.TVTTCode == "001"),
                Customer = _context.Customers.FirstOrDefault(b => b.Cif == "987654321"),
                },
            });
            await _context.SaveChangesAsync();
        }

        await _context.SaveChangesAsync();
    }
}