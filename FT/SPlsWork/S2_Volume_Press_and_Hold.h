#ifndef __S2_VOLUME_PRESS_AND_HOLD_H__
#define __S2_VOLUME_PRESS_AND_HOLD_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Volume_Press_and_Hold_UP_PRESS_DIG_INPUT 0
#define __S2_Volume_Press_and_Hold_DOWN_PRESS_DIG_INPUT 1


/*
* ANALOG_INPUT
*/




/*
* DIGITAL_OUTPUT
*/
#define __S2_Volume_Press_and_Hold_VOLUME_UP_DIG_OUTPUT 0
#define __S2_Volume_Press_and_Hold_VOLUME_DOWN_DIG_OUTPUT 1


/*
* ANALOG_OUTPUT
*/



/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Volume_Press_and_Hold )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

};

START_NVRAM_VAR_STRUCT( S2_Volume_Press_and_Hold )
{
};



#endif //__S2_VOLUME_PRESS_AND_HOLD_H__

