create database monorank;
use monorank;

create table member(
	id varchar(20) not null,
    pwd varchar(30) not null,
    name varchar(20) not null,
    findq text not null,
    finda text not null,
    contact varchar(15) not null,
    admin int not null default 0,
    primary key(id)
);
insert into member value('kmj', '1234', '김미준', '1.내 직업은?', '개발자', '010-1234-5678', 1);
insert into member value('yha', '2345', '연한아', '2.내 직업은?', '데이터 사이언티스트', '010-2345-6789', 1);
insert into member value('pja', '3456', '박정아', '3.내 직업은?', '웹툰 작가', '010-3456-7890', 0);
insert into member value('lgy', '4567', '이계영', '4.내 직업은?', '공인중개사', '010-4567-8901', 0);
insert into member value('gwy', '5678', '금위영', '5.내 직업은?', '군인', '010-5678-9012', 0);

create table assaultcraft(
	id varchar(20) not null,
	score int not null default 0,
    primary key(id),
    foreign key(id) references member(id) on delete cascade on update cascade
);
insert into assaultcraft (id) values ('kmj');
insert into assaultcraft (id) values ('yha');
insert into assaultcraft (id) values ('pja');
insert into assaultcraft (id) values ('lgy');
insert into assaultcraft (id) values ('gwy');

create table eatcookie(
	id varchar(20) not null,
    score int not null default 0,
    primary key(id),
    foreign key(id) references member(id) on delete cascade on update cascade
);
insert into eatcookie (id) values ('kmj');
insert into eatcookie (id) values ('yha');
insert into eatcookie (id) values ('pja');
insert into eatcookie (id) values ('lgy');
insert into eatcookie (id) values ('gwy');

select * from member;
select * from assaultcraft;
select * from eatcookie;