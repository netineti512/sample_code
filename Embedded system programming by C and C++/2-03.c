/**************************************
 *
 *  関数: delay()
 *
 *  内容: 要求されたミリ秒単位の数値だけ「待ち」に入る
 *
 *　注意事項:　「1引いてテストする」サイクル数は、色々な試行錯誤
 *              して決められた
 *              この数値はプロセッサの種類とその速度に依存する
 *
 *  戻り値:　　定義されていない
 *
 ***************************************/

void delay(unsigned int nMilliseconds)
{
#define CYCLES_PER_MS 260 //「１引いてテストする」サイクル数
	unsigned long nCycles = nMilliseconds * CYCLES_PER_MS;
	while (nCycles--);
}