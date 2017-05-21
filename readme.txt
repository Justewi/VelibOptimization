############## Projet Web Services ##############
Robin ALONZO
Alexandre BAR

Execution:
Lancer VisualStudio en administrateur, ouvrir la solution puis:
-Lancer le serveur (Velibs)
-Lancer un des clients (VelibsClientSOAP ou VelibsClientTCP)
-Spécifier l'adresse de départ et d'arrivé (ex: Tour eiffel, Arc de triomphe)

----------------- Question 1 --------------------
Pour la première question nous avons fait l'algorithme suivant:

-Trouver la station la plus proche de notre point de départ ayant des vélos disponibles
-Trouver la station la plus proche de notre point d'arrivé ayant des places disponibles
-Trouver avec GoogleMapsAPI le chemin le plus court avec comme détour nos deux stations

Nous n'avons pas pu integrer la verification de la disponibilité car le WebService de velib
nous bloquait car on faisait trop de requêtes et renvoyait des forbidden

---------------- Question 2 ---------------------
Voir README.doc

---------------- Question 3 ---------------------

Pour la question 3 nous avons ajouté deux endpoint à notre serveur et avons créé deux clients:
- VelibsClientSOAP
- VelibsClientTCP
