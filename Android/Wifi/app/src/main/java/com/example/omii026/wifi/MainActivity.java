package com.example.omii026.wifi;

//http://stackoverflow.com/questions/20345155/android-receive-and-send-data-through-wifi-connection-to-hardware

import android.os.Bundle;
import android.os.Handler;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Button;
import android.widget.TextView;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.net.InetAddress;
import java.net.Socket;

import java.net.UnknownHostException;

public class MainActivity extends AppCompatActivity {

    private static final String SERVER_IP = "192.168.0.104";
    private static final int SERVERPORT = 8000;
    private InetAddress serverAddr;
    private Socket socket;
    private volatile boolean stopWorker;
    private BufferedWriter wr;
    String value1,value2,sand;
    private Thread workerThread;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        final TextView textView = (TextView) findViewById(R.id.textView);

        beginListenForData();

        final FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                try {
                    wr.write("ABCDEFGH");
                    wr.flush();
                } catch (IOException e) {
                    e.printStackTrace();
                }
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();

            }
        });

    }
    void beginListenForData(){
        final Handler handler = new Handler();

        stopWorker = false;
        workerThread = new Thread(new Runnable(){
            public void run(){

                try{
                    serverAddr = InetAddress.getByName(SERVER_IP);
                    socket = new Socket(serverAddr, SERVERPORT);
                    wr = new BufferedWriter(new OutputStreamWriter(socket.getOutputStream()));
                }
                catch (IOException ex)
                {
                    stopWorker = true;
                }

            }
        });

        workerThread.start();
    }



}
