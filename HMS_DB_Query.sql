create table booking_details(uid_no varchar(30), full_name varchar(30), 
birthday varchar(12), phone_no varchar(11), cnic varchar(15), email varchar(30), 
gender varchar(8), floor_no varchar(4), room_no varchar(4), noOFguests varchar(4), 
room_type varchar(10), reserved_date varchar(12), departure_date 
varchar(12), payment_mode varchar(10), paidORnot varchar(8), 
card_no varchar(20));

insert into booking_details1 values('51500', 'Sharayar Farooqui','10/31/01', '(+92)333-0370211', '12569-9513268-7', 'shareyar8@gmail.com', 'male', '03', '33', '04', 'Double', '09/10/2022', '09/19/2022','Card', 'Yes', '1598-7643-2015-4236'); 
insert into booking_details1 values('98577', 'Sameed gpu walay','10/31/99', '(+92)356-9610391', '12240-5139268-9', 'gpu_walay@gmail.com', 'male', '04', '49', '03', 'Double', '08/10/2022', '08/15/2022','Cash', 'No', '-'); 
insert into booking_details1 values('21309', 'Nehal Ahmed','09/18/03', '(+92)316-6039851', '19229-2695138-0', 'SNA028@gmail.com', 'male', '05', '56', '03', 'Triple', '10/10/2022', '10/12/2022','Card', 'Yes', '4236-4315-2076-1598'); 

insert into booking_details1 values('88140', 'Abdul Hannan','06/6/96', '(+92)316-4851396', '42569-9513332-1', 'QariShab@gmail.com', 'male', '06', '66', '03', 'Triple', '12/19/2022', '12/20/2022','Cash', 'No', '-'); 
insert into booking_details1 values('69686', 'Berry licious','06/29/69', '(+92)355-9953168', '49569-2513268-7', 'bb123@gmail.com', 'male', '07', '70', '01', 'Queen', '12/18/2022', '12/20/2022','Cash', 'No', '-'); 
insert into booking_details1 values('99601', 'Talha anjum','1/31/00', '(+92)333-6851039', '45969-9577778-7', 'talha101@gmail.com', 'male', '08', '83', '02', 'Queen', '12/19/2022', '12/21/2022','Cash', 'No', '-'); 

insert into booking_details1 values('10276', 'Mubashir murgi','02/20/99', '(+92)356-1385196', '25619-6895132-2', 'hamza@gmail.com', 'male', '02', '27', '01', 'Single', '07/01/2022', '07/15/2022','Cash', 'No', '-'); 
insert into booking_details1 values('8540', 'Shariq jani','03/13/02', '(+92)377-8510396', '69125-5132968-3', 'shariq888@gmail.com', 'male', '09', '99', '02', 'King', '07/11/2022', '07/15/2022','Card', 'Yes', '2015-7643-1598-4236'); 
insert into booking_details1 values('95109', 'Hassan tlp_wala','12/31/00', '(+92)310-9683951', '95612-1326958-6', 'hassan902@gmail.com', 'male', '10', '100', '03', 'King', '10/31/2022', '11/15/2022','Cash', 'No', '-'); 

aler table booking_details alter column phone_no varchar(20)
select * from booking_details1;
delete  from booking_details1;

create table staff_details(s_no int, id_no varchar(30), full_name varchar(30), 
phone_no varchar(11), cnic varchar(15), email varchar(30), 
home_address varchar(30), position varchar(15), employeed_since 
varchar(16));

insert into staff_details1 values(0, '250498', 'Muhammad Mubashir', 
'92358740612', '45698-7123025-8', 'MMubashir@gmail.com', 
'Gulshan-e-Iqbal block 13D', 'Employee', '06/03/2015'); 

insert into staff_details1 values(1, '290999', 'Tahal Imran', 
'92406158742', '48712-5693025-8', 'Tahal_I@gmail.com', 
'Jail Chowrangi', 'Cashier', '04/15/2014'); 

insert into staff_details1 values(2, '70777', 'Shareyar Farooqui', 
'92381549920', '42302-9871695-8', 'Shareyar8@gmail.com', 
'Gulshan-e-Iqbal block 3', 'Head OF Hotel', '01/15/2010'); 

select * from staff_details1;
drop table staff_details;
truncate table staff_details1;