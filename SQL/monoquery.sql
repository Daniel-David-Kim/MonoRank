use monorank;

select m.id, pwd, name, findq, finda, contact, admin, r.score as eatcookie, s.score as assaultcraft from member m inner join eatcookie r on m.id=r.id inner join assaultcraft s on m.id=s.id;