Este archivo `README.md` debe estar en la raíz de la carpeta abierta en Visual Studio Code; en caso contrario deben usar el comando **File|Open Folder...** para abrir la carpeta que lo contiene.

En este problema deben demostrar que saben cómo implementar responsabilidades de hacer a partir de tarjetas CRC y que saben cómo aplicar la Ley de Demeter para evitar que un objeto tenga que conocer la estructura de los objetos con los que está indirectamente relacionado.

Sean las siguientes tarjetas CRC de las clases `Offer` y `OfferItem`

<table id="card">
    <tr>
        <td align="center" colspan="2">
            <p><b>Offer</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer la fecha final de la oferta</p>
            <p>Conocer los ítems publicados y agregar y remover ítems a la oferta</p>
            <p>Obtener el texto de la oferta para mostrar</p>
        </td>
        <td>
            <p>OfferItem</p>
        </td>
    </tr>
</table>

El texto de la oferta luce así:
```bash
Fecha: 31/3/2021
1 de 'Caja de cartón' a $23
4 de 'Placa de cartón' a $56
```

💡 El formato preciso del texto de la oferta no es importante **en la medida que incluya para cada ítem ofrecido la cantidad, el nombre del residuo y el precio**. Noten que la cantidad y el precio son responsabilidades de conocer de la clase `OfferItem` y el nombre del residuo es una responsabilidad de conocer de la clase `Residue`.

<table id="card">
    <tr>
        <td align="center" colspan="2">
            <p><b>OfferItem</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer el residuo publicado</p>
            <p>Conocer la cantidad del residuo</p>
            <p>Conocer el precio del residuo</p>
        </td>
        <td>
            <p>Residue</p>
        </td>
    </tr>
</table>

**Consigna:**

Dadas las tarjetas CRC y el código correspondiente en las carpetas `src` y `test`, completar el código que falta para:

1. Representar en C# las responsabilidades de esas tarjetas CRC
2. Agregar nuevas responsabilidades si corresponde para cumplir la Ley de Demeter
3. Que pasen todos los casos de prueba provistos

⚠️ No deben modificar los casos de prueba.

💡 El código que falta está en la clase `Offer`.