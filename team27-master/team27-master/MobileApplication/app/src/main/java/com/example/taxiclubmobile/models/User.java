package com.example.taxiclubmobile.models;

public class User {
    private int id;
    private String Name;
    private String UserType;
    private String Email;

    public User(int id, String name, String userType, String email) {
        this.id = id;
        Name = name;
        UserType = userType;
        Email = email;
    }

    public int getId() {
        return id;
    }

    public String getName() {
        return Name;
    }

    public String getUserType() {
        return UserType;
    }

    public String getEmail() {
        return Email;
    }
}
