Alter TABLE PuppyOwner (

    PRIMARY KEY (PuppyID),
    FOREIGN KEY (OwnerID) REFERENCES PuppyOwner(OwnerID)

);
