package fr.thanjuzo.passobfuscator;

import android.app.Activity;
import android.view.View;
import android.widget.TextView;
import android.widget.CheckBox;
import android.text.TextWatcher;
import android.text.Editable;
import android.text.ClipboardManager;
//import android.text.method.ReplacementTransformationMethod;
import android.os.Bundle;
//import android.util.Log;

import java.lang.StringBuilder;


public class PassObfuscatorActivity extends Activity implements TextWatcher {
	
	//private static final String TAG = "PassObfuscator";
	private TextView mTp;
	private TextView mTo;
	
    // Called when the activity is first created
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
    	mTp = (TextView) findViewById(R.id.editTextPass);
    	mTo = (TextView) findViewById(R.id.editTextObfuscated);
    	mTp.addTextChangedListener(this);
    }
    
    public void afterTextChanged (Editable s) {
    	//Log.d (TAG, "changed " + mTp.getText());
    	mTo.setText(Jam(mTp.getText().toString()));
    }
    public void beforeTextChanged(CharSequence s, int a, int b, int c) {
    }
    public void onTextChanged(CharSequence s, int a, int b, int c) {
    }
    
    public void onClickShow(View view) {
    	final CheckBox w = (CheckBox) view;
    	//Log.d (TAG, "Show " + w.isChecked());
    	//tp.setTransformationMethod(ReplacementTransformationMethod.SingleLineTransformationMethod);
    }
    
    public void onClickCopy(View view) {
    	ClipboardManager clipboard = (ClipboardManager) getSystemService(CLIPBOARD_SERVICE);
    	clipboard.setText(mTo.getText());
    	//Log.d (TAG, "copied " + mTo.getText());
    }
    
    // Copie de la version C#
    private String mSet = "abcdefghijklmnopqrstuvwxyz0123456789"; //ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private String Jam (String c)
    {
    	int len = c.length();
        StringBuilder o = new StringBuilder (len);

        // Calculer une graine, de facon non commutative
        int s32 = 9821 * len + 211327;
        for (int i = 0; i < len; ++i) s32 = (s32 << 1) ^ ((int)c.charAt(i));

        // Egrainer le generateur pseudo-alea
        for (int i = 0; i < len; ++i)
        {
            s32 = 9821 * s32 + 211327;

            int j = s32 % mSet.length();
            if (j < 0) j += mSet.length();
            o.append (mSet.charAt(j));
        }
        return o.toString();
    }

}