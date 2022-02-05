/**************************************
 *
 *  関数: toggleLed()
 *
 *  内容: 一方または両方のLEDの状態を反転させる
 *
 *　注意事項:　この関数はAcrom社のTarget188EBボード専用である
 *
 *  戻り値:　　定義されていない
 *
 ***************************************/

#define P2LTCH 0xFF5E  //P2LCTHレジスタのオフセット

void toggleLed(unsigned char ledMask)
{
	asm{
		mov dx, P2LTCH   //レジスタのアドレスをロード
		in al, dx        //レジスタの内容を読む

		mov ah, ledMask  //ledMaskをレジスタに移動
		xor al, ah       //要求されたレジスタを反転させる

		out dx, al       //新しいレジスタの内容を書き込む
	};
}