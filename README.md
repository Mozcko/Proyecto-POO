
# Proyecto Final POO

Elaborar un programa en C#, de forma individual, con las siguientes características:
Se realizará un programa que simule un juego llamado Roquemón. En este juego
participarán 2 jugadores donde cada participante escogerá su Roquemón de
preferencia para jugar. Para ello primero los jugadores deberán escribir su nombre.
Después los jugadores podrán elegir de los siguientes 3 Roquemones:

![Datos Roquemon](datosRoquemon.png)

La información escrita en la tabla anterior se deberá cargar de un archivo de texto.
Una vez elegido los Roquemones pelearán entre ellos, tomando un turno a la vez para
atacar. Ambos jugadores escogerán la habilidad que desean utilizar en dicho turno y
hasta que ambos no seleccionen una habilidad no se procederá a determinar el
resultado del turno.

Para ello se deberán seguir las siguientes reglas en el combate:

    • Se determinará quién es el Roquemon que atacará primero basado en su
    “Velocidad Efectiva” quien tenga la velocidad efectiva mayor, será el primero
    en atacar.
    • La fórmula para determinar la “Velocidad Efectiva” es:
        o Velocidad Efectiva = Velocidad + Aleatorio
        o Donde aleatorio es un número aleatorio entre 10 a -10
    • Un Roquemón es victorioso si logra que el Roquemón contrario llegue a 0
    puntos de vida.
    • La fórmula para calcular el daño de un ataque es:
        o Daño = Ataque Efectivo - Defensa
    • La fórmula para el ataque efectivo es
        o Ataque Efectivo = Ataque + Aleatorio
        o Aleatorio es un número aleatorio entre -7 a 7
    • El daño se puede duplicar en base al porcentaje de crítico del Roquemón que
    atacó.

Las habilidades disponibles para los Roquemones son:

![habilidades Roquemon](habilidadesRoquemon.png)

El programa deberá mostrar cual es el resultado de cada turno por ejemplo:

    • “Aguamón de Ricardo ha usado Torrente en el Fuegomón de Luis por 15 de
    daño”
    • “Fuegomón de Luis ha usado Flama en el Aguamón de Ricardo y el daño ha sido
    crítico haciendo 40 de daño”

El diseño de la interface gráfica queda abierto a su discreción.

El programa se evaluará en base a la siguiente rúbrica:

    • El juego permite seleccionar alguno de los 3 Roquemones y lo asociará con el
    jugador que lo seleccionó. (10 puntos)
    • Los Roquemones fueron creados con las estadísticas cargadas en el archivo de
    texto (10 puntos)
    • La interface cargará las habilidades de los Roquemones seleccionados, para que
    puedan ser usadas por los jugadores (10 puntos)
    • El turno inicia una vez que ambos jugadores hayan seleccionado su habilidad
    (10 puntos)
    • Se determina de forma correcta el turno de cada Roquemón (10 puntos)
    • El daño se calcula de forma correcta (10 puntos)
    • El daño crítico se calcula de forma correcta (10 puntos)
    • Las habilidades funcionan de forma correcta (10 puntos)
    • Se muestra el resultado de cada turno (10 puntos)
    • El combate termina de forma correcta cuando cualquiera de los Roquemones
    llega a 0 puntos de vida y anunciará que jugador fue el ganador (10 puntos)
