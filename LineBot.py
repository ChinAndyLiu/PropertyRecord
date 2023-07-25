from linebot import LineBotApi, WebhookHandler
from linebot.exceptions import InvalidSignatureError
from linebot.models import MessageEvent, TextMessage, TextSendMessage
app = Flask(__name__)
line_bot_api = LineBotApi('EXCpalBy7kEaxpG65GOHe1YpVqMKlbLZefzgk4aUupYIP7zbpYseUVobJpZqIL9tJMbSBtz8ui+DbN3wgS5wSjViDiqq9AB+r/JpaOV0IbdKN9vdQNycroP9mVVUsUT4i++uBZ4aL2MBvTk4Qv2vXQdB04t89/1O/w1cDnyilFU=')
handler = WebhookHandler('cd203d1700c5c6427995cd0f6283d142')

@app.route('/callback', methods=['POST'])
def callback():
    signature = request.headers['X-Line-Signature']
    body = request.get_data(as_text=True)
    try:
        handler.handle(body, signature)
    except InvalidSignatureError:
        abort(400)
    return 'OK'
