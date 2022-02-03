package com.example.taxiclubmobile;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Patterns;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import com.example.taxiclubmobile.api.RetroClient;
import com.example.taxiclubmobile.models.MainResponse;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class DummyCheck extends AppCompatActivity implements View.OnClickListener {

    private EditText editName, editSurname, editUsertype, editEmail, editCellNumber, editusername, editpassword;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_dummy_check);

        editName = findViewById(R.id.dummy_editName_txt);
        editSurname = findViewById(R.id.dummy_editSurname_txt);
        editUsertype = findViewById(R.id.dummy_editUsertype_txt);
        editEmail = findViewById(R.id.dummy_editEmail_txt);
        editCellNumber = findViewById(R.id.dummy_editCell_txt);
        editusername = findViewById(R.id.dummy_editusername_txt);
        editpassword = findViewById(R.id.dummy_editpassword_txt);

        findViewById(R.id.DummyCreate_btn).setOnClickListener(this);
        findViewById(R.id.Dummylogin_btn).setOnClickListener(this);

    }

    public void createuser() {
        String name = editName.getText().toString().trim();
        String surname = editSurname.getText().toString().trim();
        String usertype = editUsertype.getText().toString().trim();
        String email = editEmail.getText().toString().trim();
        String cellnumber = editCellNumber.getText().toString().trim();
        String username = editusername.getText().toString().trim();
        String password = editpassword.getText().toString().trim();

        //Validations for name field
        if(name.isEmpty()){
            editName.setError("Name is required");
            editName.requestFocus();
            return;
        }

        //Validations for surname field
        if(surname.isEmpty()){
            editSurname.setError("Surname is required");
            editSurname.requestFocus();
            return;
        }

        //Validations for usertype field
        if(usertype.isEmpty()){
            editUsertype.setError("Usertype is required");
            editUsertype.requestFocus();
            return;
        }

        //Validations for cell field
        if(cellnumber.isEmpty()){
            editCellNumber.setError("Cell is required");
            editCellNumber.requestFocus();
            return;
        }

        //Validations for email field
        if(email.isEmpty()){
            editEmail.setError("Email is required");
            editEmail.requestFocus();
            return;
        }
        if(!Patterns.EMAIL_ADDRESS.matcher(email).matches()){
            editEmail.setError("Enter valid Email address");
            editEmail.requestFocus();
            return;
        }

        //Validations for password field
        if(email.isEmpty()){
            editpassword.setError("Password is required");
            editpassword.requestFocus();
            return;
        }
        if(password.length() < 6){
            editpassword.setError("Password is too short");
            editpassword.requestFocus();
            return;
        }

        Call<MainResponse> call = RetroClient
                .getInstance()
                .getApi()
                .createuser(name, surname, usertype, email, cellnumber, username, password);

        call.enqueue(new Callback<MainResponse>() {
            @Override
            public void onResponse(Call<MainResponse> call, Response<MainResponse> response) {
                if(response.code() == 201){
                    MainResponse dr = response.body();
                    Toast.makeText(DummyCheck.this,dr.getMsg(), Toast.LENGTH_LONG).show();
                }
                else if(response.code() == 422){
                    Toast.makeText(DummyCheck.this,"User already exists", Toast.LENGTH_LONG).show();
                }
            }

            @Override
            public void onFailure(Call<MainResponse> call, Throwable t) {

            }
        });

     }

    @Override
    public void onClick(View v) {
        switch (v.getId()) {
            case R.id.DummyCreate_btn:
                createuser();
                break;
            case R.id.Dummylogin_btn:
                break;
        }
    }
}
