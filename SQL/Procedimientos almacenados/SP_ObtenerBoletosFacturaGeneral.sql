CREATE PROCEDURE SP_ObtenerBoletosFacturaGeneral
AS
BEGIN
DECLARE @cantBoletos int;
DECLARE @asientos varchar(MAX);

SET @cantBoletos = 
(
	SELECT COUNT(*) FROM Boleto AS B
)

SET @asientos = 
(
	SELECT STRING_AGG (B.boleto_asiento,', ')
	FROM Boleto AS B
)

SELECT 
@cantBoletos AS 'cantidad',
@asientos AS 'asientos',
('Boleto de tipo ' + Boleto.boleto_tipo_asiento + ', para la funcion de ' + Pelicula.pelicula_titulo) AS 'concepto', 
Funcion.funcion_precio_boleto AS 'precio_unitario',
(Funcion.funcion_precio_boleto * @cantBoletos) AS 'importe',
(Funcion.funcion_precio_boleto * @cantBoletos * 0.12) AS 'iva',
((Funcion.funcion_precio_boleto * @cantBoletos) + (Funcion.funcion_precio_boleto * @cantBoletos * 0.12)) AS 'total'

FROM Boleto 
INNER JOIN Factura ON Boleto.boleto_factura = Factura.id 
INNER JOIN Funcion ON Factura.factura_funcion = Funcion.id
INNER JOIN Pelicula ON Funcion.funcion_pelicula = Pelicula.id

GROUP BY 
Factura.id, 
Boleto.boleto_funcion, 
Boleto.boleto_tipo_asiento, 
Funcion.funcion_precio_boleto,
Pelicula.pelicula_titulo
END