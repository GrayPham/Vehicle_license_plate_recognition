from flask import Flask
from flask import request, jsonify
from flask_cors import CORS, cross_origin
import numpy as np
import cv2
import base64
import os
os.environ["KMP_DUPLICATE_LIB_OK"]="TRUE"
from werkzeug.wrappers import response

# Khai bao cong cua server
import BienSoXe.read_plate
from KhuonMat import face_recognition, update_faces, face_capture
from KhuonMatNV import face_recognitionNV, update_facesNV, face_captureNV

my_port = '8000'
scale = 0.00392
conf_threshold = 0.5
nms_threshold = 0.4

# Doan ma khoi tao server
app = Flask(__name__)
CORS(app)






# Khai bao ham xu ly request index
@app.route('/')
@cross_origin()
def index():
    return "Welcome to flask API!"

# Khai bao ham xu ly request hello_word
@app.route('/hello_world', methods=['GET'])
@cross_origin()
def hello_world():
    # Lay staff id cua client gui len
    staff_id = request.args.get('staff_id')
    # Tra ve cau chao Hello
    return "Hello "  + str(staff_id)

# Khai bao ham xu ly request detect
@app.route('/detect', methods=['POST'])
@cross_origin()
def detect():

    # Lay du lieu image B64 gui len va chuyen thanh image
    imagedetect_b64 = request.form.get('image')
    image = np.fromstring(base64.b64decode(imagedetect_b64), dtype=np.uint8)
    image = cv2.imdecode(image, cv2.IMREAD_ANYCOLOR)
    retString = BienSoXe.read_plate.detection_SVM(image)

    return retString;
@app.route('/detect2line', methods=['POST'])
@cross_origin()
def detect2line():

    # Lay du lieu image B64 gui len va chuyen thanh image
    image_b64 = request.form.get('image')
    image = np.fromstring(base64.b64decode(image_b64), dtype=np.uint8)
    image = cv2.imdecode(image, cv2.IMREAD_ANYCOLOR)
    retString = BienSoXe.read_plate.detection2line_SVM(image)


    return retString;


@app.route('/recognition', methods=['POST'])
@cross_origin()
def recognition():

    # Lay du lieu image B64 gui len va chuyen thanh image
    image_b64 = request.form.get('image')
    image = np.fromstring(base64.b64decode(image_b64), dtype=np.uint8)
    image = cv2.imdecode(image, cv2.IMREAD_ANYCOLOR)
    retStringName = face_recognition.recognitionNV(image)
    return retStringName;


@app.route('/captureImage', methods=['GET'])
@cross_origin()
def captureImage():
    nameId = request.args.get('idstring')
    face_capture.faceCapture(nameId)
    responseString = update_faces.loadImage()
    return responseString


@app.route('/captureImageNV', methods=['GET'])
@cross_origin()
def captureImageNV():
    nameId = request.args.get('idstring')
    face_captureNV.faceCapture(nameId)
    responseString = update_facesNV.loadImage()
    return responseString


@app.route('/recognitionNV', methods=['POST'])
@cross_origin()
def recognitionNV():

    # Lay du lieu image B64 gui len va chuyen thanh image
    image_b64 = request.form.get('image')
    image = np.fromstring(base64.b64decode(image_b64), dtype=np.uint8)
    image = cv2.imdecode(image, cv2.IMREAD_ANYCOLOR)
    retStringName = face_recognitionNV.recognitionNV(image)
    return retStringName;
# Thuc thi server
if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0',port=my_port)