function DiscountAmount(amount:number){
 
    var discount:Number;

    if(amount<10000){
        discount=(amount*5)/100;
        console.log(amount+" is amount so Discount is: "+discount);
       
    }else if(amount>10000 && amount<20000){
        discount=(amount*10)/100;
        console.log(amount+" is amount so Discount is: "+discount);
       
    }else if(amount>20000 && amount<30000){
        discount=(amount*15)/100;
        console.log(amount+" is amount so Discount is: "+discount);
       
    }else if(amount>30000){
        discount=(amount*25)/100;
        console.log(amount+" is amount so Discount is: "+discount);
       
    }
}

DiscountAmount(8000);