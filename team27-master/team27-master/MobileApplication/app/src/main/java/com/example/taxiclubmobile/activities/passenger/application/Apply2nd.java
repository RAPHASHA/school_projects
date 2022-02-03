package com.example.taxiclubmobile.activities.passenger.application;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

import com.example.taxiclubmobile.R;

public class Apply2nd extends AppCompatActivity {
    private Button button;
    private ImageView image;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_apply2nd);

        button = (Button) findViewById(R.id.apply_next_stage2_button_id);
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                OpenStage3();
            }
        });

        image = (ImageView) findViewById(R.id.apply_back_stage2_button_id);
        image.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                openStartupActivity();
            }
        });
    }

    public void OpenStage3(){
        Intent intent = new Intent(this, Apply3rd.class);
        startActivity(intent);
    }

    public void openStartupActivity(){
        Intent intent = new Intent(this, Apply2nd.class);
        startActivity(intent);
    }
}
