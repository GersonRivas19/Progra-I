package com.example.parcial_i;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Spinner;
import android.widget.TabHost;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    TabHost tbh;
    TextView tempVal;
    Button btn;
    Spinner spn;
    conversor objConversor = new conversor();
    Tarifa trf = new Tarifa();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);



        tbh = findViewById(R.id.tbhConversor);
        tbh.setup();

        tbh.addTab(tbh.newTabSpec("Area").setContent(R.id.tabArea).setIndicator("Area", null));
        tbh.addTab(tbh.newTabSpec("Tarifa").setContent(R.id.tbhTarifa).setIndicator("Tarifa", null));
        btn=findViewById(R.id.btnCalcular);
btn.setOnClickListener(new View.OnClickListener() {
    @Override
    public void onClick(View v) {
       tempVal=findViewById(R.id.txtCantidad);
       double cantidad = Double.parseDouble(tempVal.getText().toString());
       double tarifa = trf.CalcularTarifa(cantidad);
        Toast.makeText(getApplicationContext(), "La cantidad a pagar es de : $: " + tarifa, Toast.LENGTH_LONG).show();
    }
});


        btn = findViewById(R.id.btnAreaConvertir);
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                spn = findViewById(R.id.spnAreaDe);
                int de = spn.getSelectedItemPosition();

                spn = findViewById(R.id.spnAreaA);
                int a = spn.getSelectedItemPosition();

                tempVal = findViewById(R.id.txtAreaCantidad);
                double cantidad = Double.parseDouble(tempVal.getText().toString());

                double resp = objConversor.convertir(0, de, a, cantidad);
                Toast.makeText(getApplicationContext(), "Respuesta: " + resp, Toast.LENGTH_LONG).show();
            }
        });
    }
}


class conversor {
    double [][] valores = {
            {1, 1.4308, 1.19599, 10.7639, 0.00159033, 0.0001431, 0.0001}
    };

    public double convertir(int opcion, int de, int a, double cantidad) {
        return valores[opcion][a] / valores [opcion][de] * cantidad;
    }
}
class Tarifa{
    public double CalcularTarifa(double cantidad){
        double tarifa=6;
        if(cantidad>=19&&cantidad<=28){
            tarifa+=(cantidad-18)*0.45;
        }
        if (cantidad>28)
        {
            tarifa+=4.5+(cantidad-28)*0.65;
        }
        return tarifa;
    }
}