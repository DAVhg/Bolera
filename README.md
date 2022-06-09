# Bolera en Unity
Las escenas son
sencillas, la primera consta de una imagen de presentación y la segunda
es una vía de bolera sobre un terreno natural con árboles.

Para empezar, decidí crear dos escenas, una primera con una imagen de título
la cual consta de un canvas con un panel. 

El canvas tiene de render mode
screen space - overlay y eliminé la luz por defecto para que no afecte a la
imagen.

Después añadí un script al panel que solo carga la siguiente escena cuando se
detecta un click izquierdo.

La siguiente escena se llama Game y es el juego en si. Descargué assets
buscando en google y también unos árboles y texturas de terreno de la asset
store.

Cree un terreno, modificando el tamaño y la posición, lo deformé y añadí
arboles con el pincel, también añadí una textura natural.

Añadí el objeto de BowlingLane y coloqué encima los bolos, clonándolos y
cree la esfera que va a ser la bola.

Cree también una textura para la bola y unas etiquetas que ponerles a los
bolos y a la bola para poder identificarlos rápido en el script del juego.

Una vez ajustada la posición de todos los objetos, les añadí propiedades
físicas, de Rigid Body y BoxCollider.

Por último hice el script que apliqué a la bola, simplemente controla cuando
pulsas las teclas para reiniciar el juego, lanzar la bola, etc

La bola tiene 2.5x veces la masa de los bolos para que al dispararla los
derribe sin dificultad.

## Controles del juego
El juego consiste en dos escenas, la primera, con un gráfico introductorio al
juego solo tiene un control, hacer click izquierdo en cualquier parte del
gráfico para pasar a la siguiente escena.

La escena del juego consta de los siguientes controles:

Flechas izquierda/derecha: mover la bola de izquierda a derecha incluso
cuando se encuentra en movimiento para así poder derribar los bolos de los
bordes.

Barra espaciadora: lanzar la bola.

B: Resetea la posición de la bola.

R: Resetear posición de bolos y bola.

Esc: cierra la aplicación.

## Elementos usados
Scenes: se han utilizado dos escenas. Una con el título del juego y cuando
haces click en la pantalla, carga la segunda escena que se trata del juego
en si.

Textures: he utilizado varias texturas como la aplicada al objeto de los
bolos y la textura del terreno.

Lights: el juego consiste de 2 luces distintas, una direccional para iluminar
la escena general y otra que sale de la bola de bolos, la bola produce luz, es
de tipo point light.

Scripts: he usado dos scripts, uno llamado PanelScript que controla que
cuando hagas click en la primera escena, empiece la segunda. El otro script
sirve para controlar la bola y los bolos y los controles de teclado, para
volver a poner los bolos y bola en su posición original etcétera.

Collisions: la bola al ser lanzada por el usuario, colisiona con los bolos y los
derriba, tiene mucha más masa que ellos por lo tanto puede derribarlos. La
bola y los bolos también colisionan con la pista, para sostenerse encima.

Prefabs: los bolos están todos por tags y guardados en Prefabs ya que hay
muchos en la escena repetidos.

Particle Filter: para el particle filter he añadido un efecto de lluvia sobre la
pista de bolos, con distintas propiedades y ajustando el 3D start size para
hacerlo parecer líneas y por ejemplo con collision o lifetime para que
parezca real al chocar y no caiga por debajo de la pista hasta el infinito.

Terrain: he añadido un terreno, modificando su tamaño y posición he
conseguido centrarlo y tener un tamaño decente. He importado unos
materiales de la tienda y poniéndoselo al terreno. También lo he deformado
con el pincel y he añadido árboles.

Assets: de assets he importado un pack de naturaleza y he añadido unos
árboles al terreno, los materiales del terreno también han sido importados
de la asset store.