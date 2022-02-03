package com.example.taxiclubmobile.activities.shared.startup;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.example.taxiclubmobile.R;
import com.example.taxiclubmobile.activities.passenger.application.Apply;
import com.example.taxiclubmobile.activities.shared.login.Login;

public class Startup extends AppCompatActivity {
    private Button loginbutton;
    private Button applybutton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_startup);

        loginbutton = (Button) findViewById(R.id.login_button_id);
        loginbutton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                openLoginActivity();
            }
        });

        applybutton = (Button) findViewById(R.id.apply_button_id);
        applybutton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                openApplyActivity();
            }
        });
    }

    public void openLoginActivity(){
        Intent intent = new Intent(this, Login.class);
        startActivity(intent);
    }

    public void openApplyActivity(){
        Intent intent = new Intent(this, Apply.class);
        startActivity(intent);
    }
}
