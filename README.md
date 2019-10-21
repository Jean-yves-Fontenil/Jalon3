# Jalon3
Création d'une application Desktop de gestion gestion de covoiturage pour les adhérents d'une chorale.

## LE CAHIER DES CHARGES

### Généralités

Ce cahier des charges a un but pédagogique. Il doit vous permettre de mettre en œuvre l’essentiel des compétences nécessaires associées au module « Application desktop ».

## Contexte général

Le chant choral est une activité de loisir, populaire et très pratiquée en France. L'Aveyron n'échappe pas à cet engouement. Une chorale millavoise permet la pratique du chant en chorale et organise des concerts dans la région. 
Actuellement des fichiers au format ‘mp3’ sont en ligne pour favoriser les apprentissages.
Cette chorale fait appel à vous pour améliorer le suivi de ses activités. 
L'objectif du projet est d’enrichir l’application actuelle en proposant  une évolution visant dans un espace privé

-	A faciliter les inscriptions des adhérents
-	A permettre le suivi de la participation des choristes aux différents spectacles et activités proposés.

## Description fonctionnelle

La chorale existe depuis plus de 20 ans, et propose à ses adhérents un apprentissage de chants de divers répertoires avec plusieurs voix pour  de nombreux morceaux de musiques.
Aujourd’hui, il y a six pupitres, les contre-alti, les alti, les basses, les ténors, les mezzos et les sopranes.
L’application actuelle met à la disposition des choristes, pour favoriser les apprentissages, un ensemble de fichiers au format mp3, correspondant à chaque voix individuellement. Ils sont déjà publiés sur le web. Ainsi, pour chaque morceau travaillé, un fichier au format mp3 est disponible permettant d’écouter ; de télécharger et de travailler la voix correspondant à un pupitre.

Chaque pupitre a un ou deux responsables, chargés de faire circuler l’information.
Cette association loi 1901 outre les responsables de pupitre est gérée par un bureau de 3 membres élus par l'Assemblée Générale annuelle, le président, le secrétaire et le trésorier.
Le conseil d’administration est composé des responsables de pupitre et du bureau.
Le bureau de l'association tient à jour la liste de ses adhérents et leurs souhaits de participation aux activités proposées. Il enregistre les coordonnées (adresse, mail, téléphone) des adhérents. 

La chorale voit son nombre d'adhérents compte aujourd'hui une centaine de choristes réguliers.
L'association organise des concerts permettant de présenter son répertoire au public. Ces concerts nécessitent une certaine logistique (covoiturage, réservation de cars, hébergement…).

Pour faciliter l’organisation de ces opérations, chaque adhérent est invité à indiquer s’il est disponible pour une activité proposée (concert, voyage…). 
4 choix s’offrent à lui :
-	Il est disponible
-	Il ne peut pas se rendre disponible
-	Il ne sait pas encore
-	Il ne s’est pas encore prononcé (C’est le choix par défaut)

Pour le moment, ces listes sont gérées sous Excel et posent des problèmes de maintenance et d’accessibilité. 
 
Pour suivre un adhérent le secrétariat souhaite  connaître :

-	Son nom
-	Son prénom
-	Sa photo (pour le trombinoscope)
-	Son mail
-	Son pupitre de rattachement
-	S’il appartient au bureau ou s’il est responsable de pupitre
-	Son mot de passe (il sera crypté dans la base)
-	Son téléphone
-	Son adresse
-	Le fait d’être ou non à jour de sa cotisation pour l’année.

Pour se déterminer sur une activité donnée, les choristes souhaitent connaître
-	La date de l’activité
-	Le lieu
-	Des compléments d’information éventuels (durée, covoiturage nécessaire, prix, etc..)

## Les acteurs identifiés

L’internaute
Toute personne connaissant l’adresse du site. Elle peut accéder au site avec tous les navigateurs et tous les types d’interface web disponibles (mobile, tablette ou Desktop)

Les adhérents
Ces utilisateurs auront un identifiant spécifique qui va leur permettre d’accéder à des fonctionnalités privées.

L’administrateur du site
Il peut faire tout ce que peut faire un adhérent. Il est en plus chargé d’administrer les informations techniques du site. Il a accès aux statistiques du site.

La secrétaire
Elle peut mettre en relation les adhérents pour la gestion du covoiturage.


1.5.	Fonctionnalités attendues

L’application à développer dans cette partie sera destinée à la secrétaire de l’association. Elle devra permettre de gérer le covoiturage entre adhérents. Son but sera donc de rapprocher les personnes qui veulent proposer des places pour se rendre aux activités et ceux qui en cherchent. 

Pour une activité donnée, la secrétaire doit pouvoir rapidement voir les adhérents qui proposent des placent et ceux qui en cherchent. L’application doit alors lui permettre d’effectuer le rapprochement des personnes concernées. 

Notez que dans cette version, l’application ne gère pas la création / modification des adhérents et des activités. Ces derniers seront préalablement renseignés dans vos jeux de test directement dans le SGBD.

Cette application est exclusivement réservée à la secrétaire. Par conséquent, il n’est pas nécessaire d’implémenter une gestion des droits ou de controler les utilisateurs qui y accèdent Elle sera installée uniquement sur son poste.

## Choix techniques

Le SGBD est MySQL.

Un modèle de données de référence a été proposé par les formateurs pour que l’ensemble des stagiaires du groupe parte d'une même base en début du jalon 2. Vous repartirez donc de la même base en la faisant évoluer. La réalisation d’un jeu d’essai significatif est de votre responsabilité (Adhérents, activités, …).

Les accès se feront avec ADO.Net. 