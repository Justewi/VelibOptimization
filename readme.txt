############## Projet Web Services ##############
Robin ALONZO
Alexandre BAR

Execution:
Lancer VisualStudio en administrateur, ouvrir la solution puis:
-Lancer le serveur (Velibs)
-Lancer un des clients (VelibsClientSOAP ou VelibsClientTCP)
-Sp�cifier l'adresse de d�part et d'arriv� (ex: Tour eiffel, Arc de triomphe)

----------------- Question 1 --------------------
Pour la premi�re question nous avons fait l'algorithme suivant:

-Trouver la station la plus proche de notre point de d�part ayant des v�los disponibles
-Trouver la station la plus proche de notre point d'arriv� ayant des places disponibles
-Trouver avec GoogleMapsAPI le chemin le plus court avec comme d�tour nos deux stations

Nous n'avons pas pu integrer la verification de la disponibilit� car le WebService de velib
nous bloquait car on faisait trop de requ�tes et renvoyait des forbidden

---------------- Question 2 ---------------------
Voir README.doc

---------------- Question 3 ---------------------

Pour la question 3 nous avons ajout� deux endpoint � notre serveur et avons cr�� deux clients:
- VelibsClientSOAP
- VelibsClientTCP
