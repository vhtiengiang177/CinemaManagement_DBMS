alter procedure sp_showEmployee
as
	select id_employee as N'Mã nhân viên', 
			name_employee as N'Tên nhân viên', 
			birthday_employee as N'Ngày sinh', 
			sex_employee as N'Giới tính', 
			identitycard_employee as 'CMND', 
			phone_employee as 'SĐT', 
			email_employee as 'Email', 
			address_employee as N'Địa chỉ',  
			salary_employee as N'Lương', 
			TypeEmployee.name_typeemployee as N'Chức vụ', 
			state_employee as 'Trạng thái'
	from Employee, TypeEmployee
	where Employee.id_typeemployee = TypeEmployee.id_typeemployee
go

create procedure sp_CheckStateLogin @username nvarchar(50), @password nvarchar(20)
as
	select state_employee
	from Employee
	where username_employee = @username and password_employee = @password
go

update Employee set state_employee = 1 

create procedure sp_GetAnEmployee @id nvarchar(10)
as
	select id_employee as N'Mã nhân viên', 
			name_employee as N'Tên nhân viên', 
			birthday_employee as N'Ngày sinh', 
			sex_employee as N'Giới tính', 
			identitycard_employee as 'CMND', 
			phone_employee as 'SĐT', 
			email_employee as 'Email', 
			address_employee as N'Địa chỉ',  
			salary_employee as N'Lương', 
			id_typeemployee,
			state_employee as 'Trạng thái',
			img_employee as 'Ảnh',
			id_cinema
	from Employee
	where id_employee = @id
go

ALTER proc [dbo].[sp_search_ID_Employee]
@ID nvarchar(50)
as
begin
	select id_employee as N'Mã nhân viên', 
			name_employee as N'Tên nhân viên', 
			birthday_employee as N'Ngày sinh', 
			sex_employee as N'Giới tính', 
			identitycard_employee as 'CMND', 
			phone_employee as 'SĐT', 
			email_employee as 'Email', 
			address_employee as N'Địa chỉ',  
			salary_employee as N'Lương', 
			TypeEmployee.name_typeemployee as N'Chức vụ', 
			state_employee as 'Trạng thái'
	from Employee, TypeEmployee
	where id_employee like '%' + @ID +'%' and Employee.id_typeemployee = TypeEmployee.id_typeemployee
end
GO

ALTER proc  [dbo].[sp_search_name_Employee]
@name nvarchar(50)
as
begin
	select id_employee as N'Mã nhân viên', 
			name_employee as N'Tên nhân viên', 
			birthday_employee as N'Ngày sinh', 
			sex_employee as N'Giới tính', 
			identitycard_employee as 'CMND', 
			phone_employee as 'SĐT', 
			email_employee as 'Email', 
			address_employee as N'Địa chỉ',  
			salary_employee as N'Lương', 
			TypeEmployee.name_typeemployee as N'Chức vụ', 
			state_employee as 'Trạng thái'
	from Employee , TypeEmployee
	where name_employee like '%' + @name +'%' and Employee.id_typeemployee = TypeEmployee.id_typeemployee
end
GO


ALTER proc [dbo].[sp_search_IdentityCard_Employee]
@identityCard nvarchar(50)
as
begin
	select id_employee as N'Mã nhân viên', 
			name_employee as N'Tên nhân viên', 
			birthday_employee as N'Ngày sinh', 
			sex_employee as N'Giới tính', 
			identitycard_employee as 'CMND', 
			phone_employee as 'SĐT', 
			email_employee as 'Email', 
			address_employee as N'Địa chỉ',  
			salary_employee as N'Lương', 
			TypeEmployee.name_typeemployee as N'Chức vụ', 
			state_employee as 'Trạng thái'
	from Employee, TypeEmployee 
	where identitycard_employee like '%' + @identityCard +'%' and Employee.id_typeemployee = TypeEmployee.id_typeemployee
end
GO

ALTER proc [dbo].[sp_search_Phone_Employee]
@phone nvarchar(50)
as
begin
	select id_employee as N'Mã nhân viên', 
			name_employee as N'Tên nhân viên', 
			birthday_employee as N'Ngày sinh', 
			sex_employee as N'Giới tính', 
			identitycard_employee as 'CMND', 
			phone_employee as 'SĐT', 
			email_employee as 'Email', 
			address_employee as N'Địa chỉ',  
			salary_employee as N'Lương', 
			TypeEmployee.name_typeemployee as N'Chức vụ', 
			state_employee as 'Trạng thái'
	from Employee, TypeEmployee 
	where phone_employee like '%' + @phone +'%' and Employee.id_typeemployee = TypeEmployee.id_typeemployee
end
go

ALTER function [dbo].[fun_sort_typeEmployee](@idType nvarchar(10))
returns table as
return select id_employee as N'Mã nhân viên', 
			name_employee as N'Tên nhân viên', 
			birthday_employee as N'Ngày sinh', 
			sex_employee as N'Giới tính', 
			identitycard_employee as 'CMND', 
			phone_employee as 'SĐT', 
			email_employee as 'Email', 
			address_employee as N'Địa chỉ',  
			salary_employee as N'Lương', 
			TypeEmployee.name_typeemployee as N'Chức vụ', 
			state_employee as 'Trạng thái'
	from Employee, TypeEmployee
	where Employee.id_typeemployee = @idType and TypeEmployee.id_typeemployee = @idType

	ALTER PROC [dbo].[sp_InsertInfoEmployee]
	@id_employee nvarchar(10),
	@name_employee nvarchar(50),
	@birthday_employee date,
	@sex_employee nvarchar(50),
	@identitycard_employee nvarchar(50),
	@phone_employee nvarchar(50),
	@email_employee nvarchar(50),
	@address_employee nvarchar(50),
	@salary_employee int,
	@id_typeemployee nvarchar(10),
	@id_cinema nvarchar(10),
	@img_employee image,
	@state_employee bit
as 
begin
	insert into Employee (id_employee,name_employee,  birthday_employee, sex_employee, identitycard_employee, phone_employee, email_employee, address_employee, salary_employee, id_typeemployee, id_cinema, state_employee)
	values(@id_employee,@name_employee,  @birthday_employee, @sex_employee, @identitycard_employee, @phone_employee,@email_employee, @address_employee, @salary_employee, @id_typeemployee, @id_cinema, @state_employee)
end

ALTER  PROC [dbo].[sp_updateInforEmployee]
	@id_employee nvarchar(10),
	@name_employee nvarchar(50),
	@birthday_employee date,
	@sex_employee nvarchar(50),
	@identitycard_employee nvarchar(50),
	@phone_employee nvarchar(50),
	@email_employee nvarchar(50),
	@address_employee nvarchar(50),
	@salary_employee int,
	@id_typeemployee nvarchar(10),
	@id_cinema nvarchar(10),
	@img_employee image,
	@state_employee bit

as
begin
	update Employee set 
	name_employee = @name_employee,
	birthday_employee = @birthday_employee ,
	sex_employee = @sex_employee ,
	identitycard_employee = @identitycard_employee,
	phone_employee = @phone_employee ,
	email_employee = @email_employee ,
	address_employee = @address_employee ,
	salary_employee = @salary_employee,
	id_typeemployee = @id_typeemployee ,
	id_cinema = @id_cinema ,
	img_employee = @img_employee ,
	state_employee = @state_employee
	where Employee.id_employee = @id_employee
end

CREATE trigger [dbo].[tg_CheckCMNDEmployee] on [dbo].[Employee]
for insert, update
as if update(identitycard_employee)
begin
	declare @identitycard_ne nvarchar(50), @id_em nvarchar(10), @count_em int 
	select @identitycard_ne = identitycard_employee, @id_em = id_employee from Inserted
	set @count_em = (select count(identitycard_employee) from Employee where @identitycard_ne = identitycard_employee)
	if( @count_em > 1)
		begin
			print N'Lỗi: CMND đã tồn tại.'
			ROLLBACK TRAN
		end
end

CREATE trigger [dbo].[tg_CheckPhoneEmployee] on [dbo].[Employee]
for insert, update
as if update(phone_employee)
begin
	declare @phone_ne nvarchar(50), @id_em nvarchar(10), @count_em int 
	select @phone_ne = phone_employee, @id_em = id_employee from Inserted
	set @count_em = (select count(phone_employee) from Employee where @phone_ne = phone_employee)
	if( @count_em > 1)
		begin
			print N'Lỗi: Số điện thoại đã tồn tại.'
			ROLLBACK TRAN
		end
end

update Employee set phone_employee = '0383509600' where id_employee = 'em001'
update Employee set phone_employee = '0383509601' where id_employee = 'em002'
update Employee set phone_employee = '0383509602' where id_employee = 'em003'
update Employee set phone_employee = '0383509603' where id_employee = 'em004'
update Employee set phone_employee = '0383509604' where id_employee = 'em005'
update Employee set phone_employee = '0383509605' where id_employee = 'em006'