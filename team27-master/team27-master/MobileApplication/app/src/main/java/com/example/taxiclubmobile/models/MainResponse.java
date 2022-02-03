package com.example.taxiclubmobile.models;

import com.google.gson.annotations.SerializedName;

public class MainResponse
{
    @SerializedName("error")
    private boolean err;

    @SerializedName("message")
    private String msg;

    public MainResponse(boolean err, String msg){
        this.err = err;
        this.msg = msg;
    }

    public boolean get() {return err; }

    public String getMsg() {
        return msg;
    }

}
