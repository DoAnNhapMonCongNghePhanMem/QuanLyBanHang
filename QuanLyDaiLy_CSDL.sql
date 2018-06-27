CREATE DATABASE QuanLyDaiLy
GO
USE QuanLyDaiLy
GO

CREATE TABLE NhanVienQL(
	CMND VARCHAR(50) PRIMARY KEY NOT NULL,
	TenNV NVARCHAR(50) NOT NULL,
	NgaySinh DATE NOT NULL,
	QueQuan NVARCHAR(100) NOT NULL,
	SDT VARCHAR(50) NOT NULL
)
GO

CREATE TABLE ThongTinTaiKhoan(
	UserName VARCHAR(50) PRIMARY KEY NOT NULL,
	Pass VARCHAR(50) NOT NULL,
	CMND VARCHAR(50) NOT NULL,
	PhanQuyen INT DEFAULT 1 NOT NULL,--0 la  quyen Admin,1 la binh thuong
	TrangThai INT NOT NULL,
	FOREIGN KEY (CMND) REFERENCES NhanVienQL(CMND)
)
GO
create table Quan(
	IdQuan int identity not null primary key,
	TenQuan nvarchar(50) not null
)
go
CREATE TABLE LoaiDaiLy(
	IdLoaiDL int IDENTITY PRIMARY KEY NOT NULL,
	TenLoaiDL NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE MatHang(
	IdMatHang INT identity PRIMARY KEY NOT NULL,
	TenMatHang NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE DaiLy(
	IdDaiLy INT IDENTITY PRIMARY KEY NOT NULL,
	TenDaiLy NVARCHAR(50) NOT NULL,
	SDT VARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	IdQuan int NOT NULL,
	NgayTiepNhan DATE NOT NULL,
	IdLoaiDL int NOT NULL,
	CMND VARCHAR(50) NOT NULL,
	TienNo float not null default 0,
	FOREIGN KEY (IdLoaiDL) REFERENCES LoaiDaiLy(IdLoaiDL),
	FOREIGN KEY (CMND) REFERENCES NhanVienQL(CMND),
	FOREIGN KEY (IdQuan) REFERENCES Quan(IdQuan)
)
GO

CREATE TABLE PhieuThuTien(
	IdPhieuThu INT IDENTITY PRIMARY KEY NOT NULL,
	NgayThu DATE NOT NULL,
	SoTienThu FLOAT NOT NULL,
	IdDaiLy INT NOT NULL,
	CMND VARCHAR(50) NOT NULL,
	FOREIGN KEY (IdDaiLy) REFERENCES DaiLy(IdDaiLy),
	FOREIGN KEY (CMND) REFERENCES NhanVienQL(CMND)
)
GO
CREATE TABLE PhieuXuatHang(
	IdPhieuXuat INT IDENTITY PRIMARY KEY NOT NULL,
	NgayXuat DATE NOT NULL,
	IdDaiLy INT NOT NULL,
	CMND VARCHAR(50) NOT NULL,
	FOREIGN KEY (IdDaiLy) REFERENCES DaiLy(IdDaiLy),
	FOREIGN KEY (CMND) REFERENCES NhanVienQL(CMND)
)
GO
CREATE TABLE ChiTietXuatHang(
	IdPhieuXuat INT NOT NULL,
	IdMatHang INT NOT NULL,
	SoLuong INT NOT NULL,
	DonGia float NOT NULL,
	DonViTinh NVARCHAR(20) NOT NULL,
	ThanhTien FLOAT NOT NULL,
	FOREIGN KEY (IdPhieuXuat) REFERENCES PhieuXuatHang(IdPhieuXuat),
	FOREIGN KEY (IdMatHang) REFERENCES MatHang(IdMatHang)
)
GO
CREATE TABLE CongNo(
	IdDaiLy INT NOT NULL,
	Thang int NOT NULL,
	NoDau FLOAT NOT NULL,
	NoCuoi FLOAT NOT NULL,
	PhatSinh FLOAT NOT NULL,
	FOREIGN KEY (IdDaiLy) REFERENCES DaiLy(IdDaiLy)
)
GO
CREATE TABLE DoanhSo(
	IdDaiLy INT NOT NULL,
	Thang int NOT NULL,
	TongDoanhSo FLOAT NOT NULL,
	SoPhieuXuat INT NOT NULL,
	TyLe FLOAT NOT NULL,
	FOREIGN KEY (IdDaiLy) REFERENCES DaiLy(IdDaiLy)
)
GO
CREATE TABLE QuyDinhTienNo(
	IdLoaiDL int NOT NULL,
	TienNoToiDa float NOT NULL
)
GO

CREATE TABLE QuyDinhMatHang(
	IdMatHang int Not Null,
	DonViTinh nvarchar(50) Not null,
	DonGia float not null
)
GO

CREATE TABLE QuyCheToChuc(
	SoLoaiDaiLy int,
	SoDaiLyToiDa int,
	SoMatHang int,
	SoQuan int
)
GO

---------------CHEN DU LIEU------------

INSERT INTO NhanVienQL (CMND,TenNV,NgaySinh,QueQuan,SDT) VALUES ('206014565',N'LÊ CÔNG KHÁNH','1997-10-18','QN','01664451119')
INSERT INTO NhanVienQL (CMND,TenNV,NgaySinh,QueQuan,SDT) VALUES ('206022363',N'Nguyễn Tấn Vũ','1997-1-1',N'Bình Định','1345')

INSERT INTO ThongTinTaiKhoan (UserName,Pass,CMND,PhanQuyen,TrangThai) VALUES ('LECONGKHANH','khanh181097','206014565',0,0)
INSERT INTO ThongTinTaiKhoan (UserName,Pass,CMND,PhanQuyen,TrangThai) VALUES ('VUBD','1234','206022363',0,0)

insert into Quan (TenQuan) values (N'Quận 1')
insert into Quan (TenQuan) values (N'Quận 2')
insert into Quan (TenQuan) values (N'Quận 3')
insert into Quan (TenQuan) values (N'Quận 4')

insert into LoaiDaiLy(TenLoaiDL) values (N'Loại 1')
insert into LoaiDaiLy(TenLoaiDL) values (N'Loại 2')

insert into DaiLy (TenDaiLy,SDT,DiaChi,IdQuan,NgayTiepNhan,IdLoaiDL,CMND) values (N'Đại Lý A','09891234',N'abc,Quận 1,HCM',1,'2018-1-2',1,'206014565')
insert into DaiLy (TenDaiLy,SDT,DiaChi,IdQuan,NgayTiepNhan,IdLoaiDL,CMND) values (N'Đại Lý B','01215677',N'xyz,Quận 2,HCM',2,'2018-6-2',1,'206022363')
insert into DaiLy (TenDaiLy,SDT,DiaChi,IdQuan,NgayTiepNhan,IdLoaiDL,CMND) values (N'Đại Lý C','09777888',N'kkk,Quận 3,HCM',3,'2018-6-8',2,'206014565')
insert into DaiLy (TenDaiLy,SDT,DiaChi,IdQuan,NgayTiepNhan,IdLoaiDL,CMND) values (N'Đại Lý D','06789000',N'lck,Quận 4,HCM',4,'2018-1-8',2,'206014565')

insert into MatHang(TenMatHang) values (N'Vở 96 trang')
insert into MatHang(TenMatHang) values (N'Bút Chì')
insert into MatHang(TenMatHang) values (N'Sách Giáo Khoa')
insert into MatHang(TenMatHang) values (N'Phấn Màu')
insert into MatHang(TenMatHang) values (N'Bút Bi')


insert into PhieuXuatHang(NgayXuat,IdDaiLy,CMND) values ('2018-7-7',1,'206014565')
insert into PhieuXuatHang(NgayXuat,IdDaiLy,CMND) values ('2018-7-22',2,'206022363')
insert into PhieuXuatHang(NgayXuat,IdDaiLy,CMND) values ('2018-8-8',3,'206014565')

insert into ChiTietXuatHang(IdPhieuXuat,IdMatHang,SoLuong,DonGia,DonViTinh,ThanhTien) values (1,1,20,3000,N'Quyển',60000)
insert into ChiTietXuatHang(IdPhieuXuat,IdMatHang,SoLuong,DonGia,DonViTinh,ThanhTien) values (2,2,20,2000,N'Cây',40000)
insert into ChiTietXuatHang(IdPhieuXuat,IdMatHang,SoLuong,DonGia,DonViTinh,ThanhTien) values (3,4,10,5000,N'Hộp',50000)
insert into ChiTietXuatHang(IdPhieuXuat,IdMatHang,SoLuong,DonGia,DonViTinh,ThanhTien) values (2,3,20,10000,N'Cuốn',200000)



insert into PhieuThuTien(NgayThu,SoTienThu,IdDaiLy,CMND) values ('2018-7-7',60000,1,'206014565')
insert into PhieuThuTien(NgayThu,SoTienThu,IdDaiLy,CMND) values ('2018-7-22',240000,2,'206014565')
insert into PhieuThuTien(NgayThu,SoTienThu,IdDaiLy,CMND) values ('2018-8-8',50000,3,'206022363')
insert into PhieuThuTien (NgayThu,SoTienThu,IdDaiLy,CMND) values ('2018-08-19',30000,3,'206014565')
insert into PhieuThuTien (NgayThu,SoTienThu,IdDaiLy,CMND) values ('2018-08-10',20000,4,'206014565')

insert into CongNo(IdDaiLy,Thang,NoDau,NoCuoi,PhatSinh) values (1,7,0,0,0)
insert into CongNo(IdDaiLy,Thang,NoDau,NoCuoi,PhatSinh) values (2,7,0,0,0)
insert into CongNo(IdDaiLy,Thang,NoDau,NoCuoi,PhatSinh) values (3,8,0,0,0)

insert into DoanhSo(IdDaiLy,Thang,TongDoanhSo,SoPhieuXuat,TyLe) values (1,7,60000,1,33)
insert into DoanhSo(IdDaiLy,Thang,TongDoanhSo,SoPhieuXuat,TyLe) values (2,7,240000,1,33)
insert into DoanhSo(IdDaiLy,Thang,TongDoanhSo,SoPhieuXuat,TyLe) values (3,8,50000,1,33)
-----CÁC QUY ĐỊNH ---------------------
insert into QuyDinhTienNo values (1,50000)
insert into QuyDinhTienNo values (2,50000)

insert into QuyDinhMatHang values (1,N'Quyển',3000)
insert into QuyDinhMatHang values (2,N'Cây',2500)
insert into QuyDinhMatHang values (3,N'Cuốn',10000)
insert into QuyDinhMatHang values (4,N'Hộp',3000)
insert into QuyDinhMatHang values (5,N'Cây',3000)

insert QuyCheToChuc values (2,4,5,20)
-------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------
--LOGIN AND REGISTER USER
CREATE PROCEDURE PR_CheckLogin --0 cho phep dang nhap ,1 SAI USER,2 SAI PASS,3 BI BLOCK
@UserName VARCHAR(50),
@Pass VARCHAR(50),
@OutPut INT OUT
AS 
BEGIN
	DECLARE @KtUserName INT
	DECLARE @KtPass INT
	DECLARE @KtTrangThai INT
	SELECT @KtUserName = COUNT(UserName) FROM ThongTinTaiKhoan WHERE UserName=@UserName
	SELECT @KtTrangThai=TrangThai FROM ThongTinTaiKhoan WHERE UserName=@UserName AND TrangThai=0
	IF @KtUserName=0
	BEGIN
		set @OutPut=1
		
	END
	ELSE
	BEGIN
		SELECT @KtPass=COUNT(UserName) FROM ThongTinTaiKhoan WHERE Pass=@Pass
		IF @KtPass=0
		BEGIN
			SET @OutPut=2
		END
		ELSE
		BEGIN
		SELECT @KtTrangThai=COUNT(UserName) FROM ThongTinTaiKhoan WHERE TrangThai=0
			IF @KtTrangThai=0
			BEGIN
				SET @OutPut=3
			END
			ELSE
			BEGIN 
			SET @OutPut=0
			END
		END
	END
END
DECLARE @RS INT 
EXECUTE PR_CheckLogin @UserName='LECONGKHANH',@Pass='khanh181097',@OutPut=@RS OUT
PRINT @RS
GO

create proc PR_DangKi  ---- 0 dangki thanh cong, 1 trung user,2 nhan vien da co tai khoan,3 loi 
@CMND varchar(50),
@TenNV nvarchar(50),
@NgaySinh date,
@QueQuan nvarchar(100),
@SDT varchar(50),
@UserName varchar(50),
@Pass varchar(50),
@PhanQuyen int,
@TrangThai int,
@result int out
as
begin
	declare @ktcmnd int 
	declare @ktuser int
	select @ktuser =count(UserName) from ThongTinTaiKhoan where UserName=@UserName
	if @ktuser>0
	begin
		set @result=1
		return
	end
	else 
	begin
	select @ktcmnd =count(CMND) from NhanVienQL where CMND=@CMND
		if @ktcmnd>0
		begin
			set @result=2
			return
		end
	end
	begin try
		begin transaction dk
		insert into NhanVienQL (CMND,TenNV,NgaySinh,QueQuan,SDT) values (@CMND,@TenNV,@NgaySinh,@QueQuan,@SDT)
		insert into ThongTinTaiKhoan(UserName,Pass,CMND,PhanQuyen,TrangThai) values (@UserName,@Pass,@CMND,@PhanQuyen,@TrangThai)
		commit transaction dk	
		set @result=0
	end try
	begin catch
		set @result=3
		rollback transaction dk
	end catch
end
declare @rs int
EXEC PR_DangKi '123',N'haha','1998-10-10','hcm','123','LECONGKHANH','khanh123',0,0,@rs out
print @rs
go
------------------------------------------------------------------------------------
--LOẠI ĐẠI LÝ
alter proc PR_InsertLoaiDaiLy
@TenLoaiDL nvarchar(50) 
as
begin
	declare @ktTen int
	declare @slLoaiDL int
	declare @quyDinhSoLoaiDL int
	select @ktTen=count(TenLoaiDL) from LoaiDaiLy where TenLoaiDL=@TenLoaiDL
	select @slLoaiDL=count(IdLoaiDL) from LoaiDaiLy 
	select @quyDinhSoLoaiDL=SoLoaiDaiLy from QuyCheToChuc

	if @ktTen=0
	begin
		if(@slLoaiDL<@quyDinhSoLoaiDL)
		begin
			insert into LoaiDaiLy (TenLoaiDL) values (@TenLoaiDL)
			return 1
		end
		else
		begin 
			return 2
		end	
	end
	else
	begin
		return 3
	end
end
go
------------------------------------------------------------------------------------
--TIẾP NHẬN ĐẠI LÝ 
create PROC PR_InsertDl --0 thêm thành công ,1 tên đại lý tồn tại,2 lỗi thêm
@TenDL nvarchar(50),@SDT varchar(50),@DiaChi nvarchar(50),@IdQuan int,@NgayTiepNhan date,
@IdLoaiDL int,@CMND varchar(50)
as
begin
	declare @ktTenDL int
	declare @soDaiLyQuyDinh int
	declare @soDaiLyTrongQuan int
	select @ktTenDL=count(TenDaiLy) from DaiLy where TenDaiLy=@TenDL
	select @soDaiLyQuyDinh=SoQuan from QuyCheToChuc
	select @soDaiLyTrongQuan=count(IdDaiLy) from DaiLy where IdQuan=@IdQuan
	if @ktTenDL=0
	begin
		if(@soDaiLyTrongQuan<@soDaiLyQuyDinh)
		begin
			insert into DaiLy (TenDaiLy,SDT,DiaChi,IdQuan,NgayTiepNhan,IdLoaiDL,CMND) values (@TenDL,@SDT,@DiaChi,@IdQuan,
			@NgayTiepNhan,@IdLoaiDL,@CMND)
			return 1
		end
		else
		begin
			return 2
		end
	end
	else 
	begin
		return 3
	end
end
go
create PROC PR_UpdateDL
@IdDaiLy int,@TenDaiLy nvarchar(50),@SDT varchar(50),@DiaChi nvarchar(100),@IdQuan int,
@NgayTiepNhan date,@IdLoaiDL int,@CMND varchar(50),@TienNo float
as
begin
	declare @tienNoQuyDinh float
	select @tienNoQuyDinh=TienNoToiDa from QuyDinhTienNo where IdLoaiDL=@IdLoaiDL
	if(@TienNo<=@tienNoQuyDinh)
	begin
		UPDATE DaiLy SET TenDaiLy=@TenDaiLy,SDT =@SDT,DiaChi=@DiaChi,NgayTiepNhan=@NgayTiepNhan,
		IdLoaiDL=@IdLoaiDL,CMND=@CMND,IdQuan=@IdQuan WHERE IdDaiLy=@IdDaiLy
		return 1
	end
	else
	begin
		return 2
	end
end
go
--------------------------------------------------------------------------------------
--MẶT HÀNG
CREATE proc PR_InsertMatHang
@TenMatHang nvarchar(50) 
as
begin
	declare @ktTen int
	declare @soLuongMHQuyDinh int
	declare @soLuongMatHang int
	select @ktTen=count(TenMatHang) from MatHang where TenMatHang=@TenMatHang
	select @soLuongMHQuyDinh= SoMatHang from QuyCheToChuc
	select @soLuongMatHang=count(IdMatHang) from MatHang
	if @ktTen=0
	begin
		if(@soLuongMatHang<@soLuongMHQuyDinh)
		begin
			insert into MatHang (TenMatHang) values (@TenMatHang)
			return 1
		end
		else
		begin
			return 2
		end
	end
	else
	begin
		return 3
	end
end
go
------------------------------------------------------
-----Quận
create proc PR_InsertQuan
@TenQuan nvarchar(50) 
as
begin
	declare @ktTen int
	declare @quyDinhSLQuan int
	declare @soLuongQuan int 
	select @ktTen=count(TenQuan) from Quan where TenQuan=@TenQuan
	select @quyDinhSLQuan=SoQuan from QuyCheToChuc
	select @soLuongQuan=count(IdQuan) from Quan
	if @ktTen=0
	begin
		if(@soLuongQuan<@quyDinhSLQuan)
		begin 
			insert into Quan (TenQuan) values (@TenQuan)
			return 1
		end
		else
		begin
			return 2
		end
	end
	else
	begin
		return 3
	end
end
go

--------------------------------------------------------------------------------------
--BÁO CÁO DOANH SỐ (ngày 26/6/2018)
--tính tổng tiền trong tháng
create function FN_TongTienTrongThang(@thang int)
returns float
as
begin
	declare @tongTien float
	select @tongtien=sum(SoTienThu) from PhieuThuTien where MONTH(NgayThu)=@thang
	if(@tongTien=0)
		return 1
	return @tongtien
end
go
--tỷ lệ
create function FN_TyLeTrongThang(@idDL int,@thang int)
returns float
as
begin
	declare @tyle float
	select @tyle=sum(SoTienThu)*100/dbo.FN_TongTienTrongThang(@thang)
	from PhieuThuTien 
	where IdDaiLy=@idDL and MONTH(NgayThu)=@thang
	group by IdDaiLy
	return @tyle
end
go
--báo cáo
create proc PR_BaoCaoDoanhSo
@Thang int
as
begin
	select T.IdDaiLy as idDL, sum(SoTienThu) as TongTien,count(IdPhieuThu) as SoPhieuXuat,
	dbo.FN_TyLeTrongThang(T.IdDaiLy,MONTH(T.NgayThu)) as tyle,MONTH(T.NgayThu) as Thang 
	 from PhieuThuTien T,PhieuXuatHang H 
	 where T.IdDaiLy=H.IdDaiLy and MONTH(T.NgayThu)=@Thang
	 group by T.IdDaiLy,MONTH(T.NgayThu)

end
go
--------------------------------------------------------------------------------------
--BÁO CÁO CÔNG NỢ
create function FN_NoDau(@thang int,@id int)
returns float
as
begin
	declare @tienNo float
	set @tienNo=0
	select top 1 @tienNo= D.TienNo from DaiLy D,PhieuThuTien P
	where D.IdDaiLy=P.IdDaiLy and MONTH(P.NgayThu)=@Thang-1
	order by DAY(P.NgayThu) DESC
	return @tienNo
end
go

create function FN_NoCuoi(@thang int,@id int)
returns float
as
begin
	declare @tienNo float
	set @tienNo=0
	select top 1 @tienNo= D.TienNo from DaiLy D,PhieuThuTien P
	where D.IdDaiLy=P.IdDaiLy and MONTH(P.NgayThu)=@Thang
	order by DAY(P.NgayThu) ASC
	return @tienNo
end
go

create proc PR_BaoCaoCongNo
@Thang int
as
begin
	select P.IdDaiLy as IdDL,@Thang as Thang,dbo.FN_NoDau(@Thang,P.IdDaiLy) as NoDau,dbo.FN_NoCuoi(@thang,P.IdDaiLy) as NoCuoi
	from PhieuThuTien P,DaiLy D
	where P.IdDaiLy=D.IdDaiLy and MONTH(P.NgayThu)=@Thang
	group by P.IdDaiLy
end
go


