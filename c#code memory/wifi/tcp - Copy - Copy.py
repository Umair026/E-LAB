import socket 
TCP_IP = '192.168.0.101' # ip of pi
TCP_PORT = 800 # port no
BUFFER_SIZE = 1  # Recieve One character at atime
def main():
    while(1):
        s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        s.bind((TCP_IP, TCP_PORT))
        s.listen(1)
        conn, addr = s.accept()
        print ('Connected')
        print ('Connection address:', addr)
        while (1):
            data = conn.recv(BUFFER_SIZE)
            if not data:
                 break
            print ("received data:", data)
            print(data[0])
            conn.send(data)  # echo
        print ('Disconnected')
#conn.close()
if __name__=='__main__':
    main()
