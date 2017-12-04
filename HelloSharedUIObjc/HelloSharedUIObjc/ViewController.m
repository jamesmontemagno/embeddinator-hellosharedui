//
//  ViewController.m
//  HelloSharedUIObjc
//
//  Created by James Montemagno on 12/4/17.
//  Copyright © 2017 James Montemagno. All rights reserved.
//

#import "ViewController.h"
#import "HelloSharedUI.iOS/HelloSharedUI.iOS.h"

@interface ViewController ()

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
}


- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}


- (IBAction)NavigateClicked:(id)sender {
    
    HelloSharedUI_UIHelpers *helpers = [[HelloSharedUI_UIHelpers alloc] init];
    
    [helpers showMyPage];
}
@end
