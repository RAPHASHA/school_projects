package com.example.taxiclubmobile.api;

import com.example.taxiclubmobile.models.LoginResponse;
import com.example.taxiclubmobile.models.MainResponse;
import com.google.gson.annotations.SerializedName;

import retrofit2.Call;
import retrofit2.http.Field;
import retrofit2.http.FormUrlEncoded;
import retrofit2.http.POST;

public interface Api {

    @FormUrlEncoded
    @POST("createuser")
    Call<MainResponse> createuser(
            @Field("Name") String Name,
            @Field("Surname") String Surname,
            @Field("UserType") String UserType,
            @Field("Email") String Email,
            @Field("Cell") String Cell,
            @Field("Username") String Username,
            @Field("Password") String Password
    );

    @FormUrlEncoded
    @POST("userlogin")
    Call<LoginResponse> userLogin(
        @Field("Email") String Email,
        @Field("Password") String Password
    );
}
