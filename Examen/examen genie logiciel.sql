/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: Professeur
------------------------------------------------------------*/
CREATE TABLE Professeur(
	CIN             INT  NOT NULL ,
	Nom             VARCHAR (50) NOT NULL ,
	Postnom         VARCHAR (50) NOT NULL ,
	Prenom          VARCHAR (50) NOT NULL ,
	Sexe            CHAR (6)  NOT NULL ,
	DateNaissance   VARCHAR (50) NOT NULL ,
	Adresse         VARCHAR (50) NOT NULL ,
	telephone       VARCHAR (15) NOT NULL ,
	Email           VARCHAR (50) NOT NULL ,
	Titre           VARCHAR (30) NOT NULL  ,
	CONSTRAINT Professeur_PK PRIMARY KEY (CIN)
);


/*------------------------------------------------------------
-- Table: Salle
------------------------------------------------------------*/
CREATE TABLE Salle(
	id_salle     INT  NOT NULL ,
	Nom_Salle    VARCHAR (20) NOT NULL ,
	Type_Salle   VARCHAR (20) NOT NULL ,
	Capacite     INT  NOT NULL  ,
	CONSTRAINT Salle_PK PRIMARY KEY (id_salle)
);


/*------------------------------------------------------------
-- Table: Options
------------------------------------------------------------*/
CREATE TABLE Options(
	Nom_option   VARCHAR (30) NOT NULL  ,
	CONSTRAINT Options_PK PRIMARY KEY (Nom_option)
);


/*------------------------------------------------------------
-- Table: parcours
------------------------------------------------------------*/
CREATE TABLE parcours(
	nom_parcours   VARCHAR (10) NOT NULL  ,
	CONSTRAINT parcours_PK PRIMARY KEY (nom_parcours)
);


/*------------------------------------------------------------
-- Table: etudiant 
------------------------------------------------------------*/
CREATE TABLE etudiant(
	CNE                 INT  NOT NULL ,
	Nom                 VARCHAR (50) NOT NULL ,
	Postnom             VARCHAR (50) NOT NULL ,
	Prenom              VARCHAR (50) NOT NULL ,
	Sexe                CHAR (6)  NOT NULL ,
	DateNaissance       VARCHAR (50) NOT NULL ,
	Adresse             VARCHAR (50) NOT NULL ,
	telephone           VARCHAR (15) NOT NULL ,
	Email               VARCHAR (50) NOT NULL ,
	Frais               INT  NOT NULL ,
	AnneeObtentionBac   VARCHAR (15) NOT NULL ,
	Nom_option          VARCHAR (30) NOT NULL ,
	nom_parcours        VARCHAR (10) NOT NULL  ,
	CONSTRAINT etudiant_PK PRIMARY KEY (CNE)

	,CONSTRAINT etudiant_Options_FK FOREIGN KEY (Nom_option) REFERENCES Options(Nom_option)
	,CONSTRAINT etudiant_parcours0_FK FOREIGN KEY (nom_parcours) REFERENCES parcours(nom_parcours)
);


/*------------------------------------------------------------
-- Table: Classe
------------------------------------------------------------*/
CREATE TABLE Classe(
	nom_classe      VARCHAR (20) NOT NULL ,
	niveau_classe   VARCHAR (20) NOT NULL  ,
	CONSTRAINT Classe_PK PRIMARY KEY (nom_classe)
);


/*------------------------------------------------------------
-- Table: Module
------------------------------------------------------------*/
CREATE TABLE Module(
	Nom_Module         VARCHAR (30) NOT NULL ,
	Moyenne_generale   INT  NOT NULL ,
	charge_horaire     INT  NOT NULL ,
	nom_classe         VARCHAR (20) NOT NULL  ,
	CONSTRAINT Module_PK PRIMARY KEY (Nom_Module)

	,CONSTRAINT Module_Classe_FK FOREIGN KEY (nom_classe) REFERENCES Classe(nom_classe)
);


/*------------------------------------------------------------
-- Table: Cours
------------------------------------------------------------*/
CREATE TABLE Cours(
	Nom_cours    VARCHAR (50) NOT NULL ,
	id_salle     INT  NOT NULL ,
	CIN          INT  NOT NULL ,
	Nom_Module   VARCHAR (30) NOT NULL  ,
	CONSTRAINT Cours_PK PRIMARY KEY (Nom_cours)

	,CONSTRAINT Cours_Salle_FK FOREIGN KEY (id_salle) REFERENCES Salle(id_salle)
	,CONSTRAINT Cours_Professeur0_FK FOREIGN KEY (CIN) REFERENCES Professeur(CIN)
	,CONSTRAINT Cours_Module1_FK FOREIGN KEY (Nom_Module) REFERENCES Module(Nom_Module)
);


/*------------------------------------------------------------
-- Table: PayementFrais
------------------------------------------------------------*/
CREATE TABLE PayementFrais(
	numero_facture   INT  NOT NULL ,
	typePayement     VARCHAR (10) NOT NULL ,
	montatApayer     INT  NOT NULL ,
	CNE              INT  NOT NULL  ,
	CONSTRAINT PayementFrais_PK PRIMARY KEY (numero_facture)

	,CONSTRAINT PayementFrais_etudiant_FK FOREIGN KEY (CNE) REFERENCES etudiant(CNE)
);


/*------------------------------------------------------------
-- Table: Connexion
------------------------------------------------------------*/
CREATE TABLE Connexion(
	Username   VARCHAR (50) NOT NULL ,
	Password   VARCHAR (50) NOT NULL ,
	Email      VARCHAR (50) NOT NULL  ,
	CONSTRAINT Connexion_PK PRIMARY KEY (Username)
);


/*------------------------------------------------------------
-- Table: assigner
------------------------------------------------------------*/
CREATE TABLE assigner(
	id_salle   INT  NOT NULL ,
	CIN        INT  NOT NULL  ,
	CONSTRAINT assigner_PK PRIMARY KEY (id_salle,CIN)

	,CONSTRAINT assigner_Salle_FK FOREIGN KEY (id_salle) REFERENCES Salle(id_salle)
	,CONSTRAINT assigner_Professeur0_FK FOREIGN KEY (CIN) REFERENCES Professeur(CIN)
);



