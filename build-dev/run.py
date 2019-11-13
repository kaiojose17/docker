import logging
import http.server
import socketserver
import getpass

class myHttpHandler(http.server.SimpleHTTPRequestHandler):
    def log_message(self, format, *args):
        logging.info("%s - - [%s] %s\n"% (
            self.client_address[0],
            self.log_date_time_string(),
            format%args
        ))

logging.basicConfig(
    filename='/log/http-server.log',
    format='%(asctime) - %(levelname)s - %(message)s',
    level=logging.INFO
)
logging.getLogger().addHandler(logging.StreamHandler())
logging.info('Inicializando...')
PORT=8000


httpd = socketserver.TCPServer(("", PORT), myHttpHandler)
logging.info('escutando a porta %s', PORT)
logging.info('usuário: %s', getpass.getuser())
httpd.serve_forever()
