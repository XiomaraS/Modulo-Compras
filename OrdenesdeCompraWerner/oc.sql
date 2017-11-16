use hotelsancarlosv2;
create table ORDENESDECOMPRA(
id_oc int ,
idProveedores int,
idProducto int,
cantidad int,
categoria varchar(50)

);
 create table noORDENESDECOMPRA(id_oc int primary key);
 create table controldemoras(
idcontroldemoras int primary key AUTO_INCREMENT ,
id_oc int,
fecha_prevista_de_recibido date,
fecha_entregada date,
demora int


);

CREATE table controldevolucion(
idcontroldevolucion int primary key,
id_oc int ,
devoluacion_autorizada binary,
descripcion varchar(50)

);
alter table controldemoras  add CONSTRAINT `fk_demoraOC`
    FOREIGN KEY (id_oc)
    REFERENCES noORDENESDECOMPRA(id_oc);
    alter table controldevolucion add CONSTRAINT `fk_devolucionOC`
    FOREIGN KEY (id_oc)
    REFERENCES noORDENESDECOMPRA(id_oc);
  alter table ORDENESDECOMPRA add CONSTRAINT `fk_OC`
    FOREIGN KEY (id_oc)
    REFERENCES noORDENESDECOMPRA(id_oc);


