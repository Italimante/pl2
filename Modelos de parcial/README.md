# Modelos de parcial

### Primer parcial (PP)
- EquipoJugadores

- EquiposJugadores: _Falta validar los input del formulario_
- Estacionamiento: _Falta validar y el formulario tambi�n_
- CoiqueriaApp: _Lo uso de pr�ctica para el recuperatorio, agregandole un formulario de alta_

# Ex�menes


## Primer parcial

- **pp_ComiqueriaApp:** _Primera parcial de laboratorio, falta realizar la parte del formulario ventas, ordenar lista y otras errores que todav�a no me di cuenta pero de haber_

- **pp_ComiqueriaApp(SRC).zip:** _Enunciado del parcial en limpio y soluci�n inicial con el que arrancar_

- **Nota:** Aprobado
- **Devoluci�n del profesor:**
    - [X] Sin Form
    - [X] Repite c�digo en constructores de Producto, no los reutiliza _(Creo que lo correg� tambi�n)_
    - [X] Logica de Vender(int cantidad) mal
    - [X] No ordena las ventas
    - [X] operator + repite c�digo _(Creo que lo correg�)_

- **Nota:** 6
- **Devoluci�n del profesor: (RECUPERATORIO)**
    - [ ] � 9 � Comprobante. M�todo Equals. No pod�s castear a comprobante antes de asegurarte que el objeto pasado como argumento sea de ese tipo, si no es te va a dar error. El orden correcto del algoritmo es: Verificar que sea de tipo comprobante, castear a comprobante y, por �ltimo, verificar que la fecha de emisi�n sea la misma. (0.25)
    - [ ] � 4 � Factura. No reutiliza correctamente las sobrecargas del constructor. (0.5)
    - [ ] � Factura. OJO! El constructor suma los d�as para vencimiento a la fecha actual, no a la fecha de la venta.
    - [ ] � 5 � Factura. M�todo Equals. Hay que reutilizar c�digo y llamar al Equals de la clase base para evaluar la fecha de emisi�n. (0.5)
    - [ ] � 12 � Factura. M�todo Equals. Falta validar TipoFactura. (0.25)
    - [ ] � Factura � M�todo Generar Comprobante. � OJO!! No volver a calcular el IVA porque el par�metro que determina el porcentaje a descontar est� en la clase venta, restarle al importe total el subtotal.
    - [ ] � 7 � Comiqueria. Indexador. No carga la lista de comprobantes. (0.5)
    - [ ] � 7 � Comiqueria. Indexador. No ordena la lista de comprobantes. (0.5)
    - [ ] � 6 � Comiqueria. Indexador. No compara c�digos de productos. (0.25).
    - [ ] � 14 � Comiqueria. Sobrecarga ==. Hay que recorrer la lista y usar el m�todo Equals para comparar los comprobantes. (0.25)
    - [ ] � ModificarProductoForm � OJO! No es necesario pasarle la instancia de Comiqueria, no se usa.
    - [ ] � 10 - ModificarProductoForm � Falta formatear el precio actual para que se vea con 2 decimales. (0.25)
    - [ ] � ModificarProductoForm � OJO! Falta cambiar la propiedad ForeColor del lblError.
    - [ ] � ModificarProductoForm � OJO! Los botones del message box deben ser s�/no y no ok/cancel.

## Segundo parcial
- **sp_ComiqueriaApp:** _Segundo pparcial de laboratorio, como el orto, nada que agregar_
- **sp_ComiqueriaApp(SRC).zip:** _Enunciado del parcial en limpio, script para la base de datos y soluci�n inicial con el que arrancar_