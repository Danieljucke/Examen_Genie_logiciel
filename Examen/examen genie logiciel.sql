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
	Capacite     INT  NOT NULL ,
	id_cours     INT  NOT NULL  ,
	CONSTRAINT Salle_PK PRIMARY KEY (id_salle) ,
	CONSTRAINT Salle_AK UNIQUE (id_cours)
);


/*------------------------------------------------------------
-- Table: Option
------------------------------------------------------------*/
CREATE TABLE Option(
	id_option    INT  NOT NULL ,
	Nom_option   VARCHAR (30) NOT NULL  ,
	CONSTRAINT Option_PK PRIMARY KEY (id_option)
);


/*------------------------------------------------------------
-- Table: parcours
------------------------------------------------------------*/
CREATE TABLE parcours(
	id_parcours    INT  NOT NULL ,
	nom_parcours   VARCHAR (10) NOT NULL  ,
	CONSTRAINT parcours_PK PRIMARY KEY (id_parcours)
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
	id_option           INT  NOT NULL ,
	id_parcours         INT  NOT NULL  ,
	CONSTRAINT etudiant_PK PRIMARY KEY (CNE)

	,CONSTRAINT etudiant_Option_FK FOREIGN KEY (id_option) REFERENCES Option(id_option)
	,CONSTRAINT etudiant_parcours0_FK FOREIGN KEY (id_parcours) REFERENCES parcours(id_parcours)
);


/*------------------------------------------------------------
-- Table: Classe
------------------------------------------------------------*/
CREATE TABLE Classe(
	id_classe       INT  NOT NULL ,
	nom_classe      VARCHAR (20) NOT NULL ,
	niveau_classe   VARCHAR (20) NOT NULL  ,
	CONSTRAINT Classe_PK PRIMARY KEY (id_classe)
);


/*------------------------------------------------------------
-- Table: Module
------------------------------------------------------------*/
CREATE TABLE Module(
	id_module          INT  NOT NULL ,
	Nom_Module         VARCHAR (30) NOT NULL ,
	Moyenne_generale   INT  NOT NULL ,
	charge_horaire     INT  NOT NULL ,
	id_classe          INT  NOT NULL  ,
	CONSTRAINT Module_PK PRIMARY KEY (id_module)

	,CONSTRAINT Module_Classe_FK FOREIGN KEY (id_classe) REFERENCES Classe(id_classe)
);


/*------------------------------------------------------------
-- Table: Cours
------------------------------------------------------------*/
CREATE TABLE Cours(
	id_cours    INT  NOT NULL ,
	Nom_cours   VARCHAR (50) NOT NULL ,
	id_salle    INT  NOT NULL ,
	CIN         INT  NOT NULL ,
	id_module   INT  NOT NULL  ,
	CONSTRAINT Cours_PK PRIMARY KEY (id_cours)

	,CONSTRAINT Cours_Salle_FK FOREIGN KEY (id_salle) REFERENCES Salle(id_salle)
	,CONSTRAINT Cours_Professeur0_FK FOREIGN KEY (CIN) REFERENCES Professeur(CIN)
	,CONSTRAINT Cours_Module1_FK FOREIGN KEY (id_module) REFERENCES Module(id_module)
);


/*------------------------------------------------------------
-- Table: PayementFrais
------------------------------------------------------------*/
CREATE TABLE PayementFrais(
	numero_facture   INT  NOT NULL ,
	typePayement     VARCHAR (10) NOT NULL ,
	montatApayer     INT  NOT NULL  ,
	CONSTRAINT PayementFrais_PK PRIMARY KEY (numero_facture)
);


/*------------------------------------------------------------
-- Table:  Etre assigner 
------------------------------------------------------------*/
CREATE TABLE Etre_assigner(
	id_salle   INT  NOT NULL ,
	CIN        INT  NOT NULL  ,
	CONSTRAINT Etre_assigner_PK PRIMARY KEY (id_salle,CIN)

	,CONSTRAINT Etre_assigner_Salle_FK FOREIGN KEY (id_salle) REFERENCES Salle(id_salle)
	,CONSTRAINT Etre_assigner_Professeur0_FK FOREIGN KEY (CIN) REFERENCES Professeur(CIN)
);


/*------------------------------------------------------------
-- Table: Payer
------------------------------------------------------------*/
CREATE TABLE Payer(
	CNE              INT  NOT NULL ,
	numero_facture   INT  NOT NULL  ,
	CONSTRAINT Payer_PK PRIMARY KEY (CNE,numero_facture)

	,CONSTRAINT Payer_etudiant_FK FOREIGN KEY (CNE) REFERENCES etudiant(CNE)
	,CONSTRAINT Payer_PayementFrais0_FK FOREIGN KEY (numero_facture) REFERENCES PayementFrais(numero_facture)
);



